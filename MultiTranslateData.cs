using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace FibbageQEdit
{
    class MultiTranslateData: List<TranslateData>
    {
        private const string DATAJET = @"\data.jet";
        
        private List<FibbaggeQuestionJSON> FTranslatedQuestions;
        public MultiTranslateData(List<FibbaggeQuestionJSON> aOrgQuestions, List<FibbaggeQuestionJSON> aTranslatedQuestions)
        {
            FTranslatedQuestions = aTranslatedQuestions;
            foreach (var singleData in aOrgQuestions)
            {
                var translatedQuestion = FindQuestionWithId(singleData.id);
                Add(new TranslateData(singleData, translatedQuestion));
            }
        }

        private FibbaggeQuestionJSON FindQuestionWithId(string aId)
        {
            if (FTranslatedQuestions != null)                
                foreach (var singleData in FTranslatedQuestions)
                {
                    if (singleData.id == aId)
                        return singleData;
                }
            return null;
        }

        public void SaveToFile(string aPath)
        {
            if (!Directory.Exists(aPath))
                Directory.CreateDirectory(aPath);

            var setting = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, StringEscapeHandling = StringEscapeHandling.EscapeNonAscii };
            var encoding = new UTF8Encoding(false);
            foreach (var singleItem in this)
            {
                var newDir = aPath + singleItem.Id;
                if (!Directory.Exists(newDir))
                    Directory.CreateDirectory(newDir);

                var dataToSave =
                    JsonConvert.SerializeObject(singleItem.TranslatedData, Newtonsoft.Json.Formatting.None, setting);
                dataToSave = dataToSave.Replace("</i>", @"<\/i>");
                dataToSave = dataToSave.Replace(@"\u00e9", "é");
                File.WriteAllText(newDir + DATAJET, dataToSave, encoding);
            }
        }
    }
}
