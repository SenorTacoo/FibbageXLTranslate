using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.IO;
using System.Threading.Tasks;

abstract class Config
{
    private readonly string CFGFILE = String.Format("{0}.cfg", System.Diagnostics.Process.GetCurrentProcess().ProcessName);
    public Config()
    {
        SetDefaultValues();
        TryLoadDataFromFile();
    }

    private void TryLoadDataFromFile()
    {
        if (File.Exists(CFGFILE))
            LoadDataFromFile();
    }

    private void LoadDataFromFile()
    {
        string field, value;
        var lines = File.ReadAllLines(CFGFILE);
        foreach (var line in lines)
        {
            if (line.Contains("="))
            {
                field = "";
                value = "";
                field = line.Split('=')[0];
                value = line.Split('=')[1];
                SetConfigData(field, value);
            }
        }
    }

    public void SaveDataToFile()
    {
        Type myType = GetType();
        var properties = myType.GetProperties();
        if (properties.Length > 0)
        {
            File.Delete(CFGFILE);
            foreach (var property in properties)
            {
                try
                {
                    var name = property.Name;
                    if (property.GetValue(this) is Config)
                    {
                        continue;
                    }
                    else
                    {
                        var value = property.GetValue(this);
                        File.AppendAllText(CFGFILE, String.Format("{0}={1}", name, value));
                    }
                }
                catch(Exception e) {  }
            }
        }
    }
    protected virtual void SetConfigData(string aField, string aValue)
    {
        Type myType = GetType();
        var property = myType.GetProperty(aField);
        if (property != null)
        {
            try
            {
                var data = Convert.ChangeType(aValue, property.PropertyType);
                property.SetValue(this, data);
            }
            catch { }
        }
    }
    protected abstract void SetDefaultValues();
}
