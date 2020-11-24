using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbageQEdit
{
    class AppConfig : Config
    {
        private string FLastUsedPath;

        private static AppConfig FConfig;

        protected override void SetDefaultValues()
        {
            FLastUsedPath = "";
        }

        public string LastUsedPath
        {
            get { return FLastUsedPath; }
            set { FLastUsedPath = value; }
        }

        public static AppConfig Configuration
        {
            get {
                    if (FConfig == null)
                    {
                        FConfig = new AppConfig();
                    }
                    return FConfig;
                }
        }
    }
}
