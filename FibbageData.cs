using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FibbageQEdit
{
    class FibbageData
    {
        private const string CONTENT_DIR = @"\content";
        private const string TRANSLATE_DIR = @"\translated";
        private const string SHORTIE_DIR = @"\fibbageshortie\";
        private const string FINALFIBBAGE_DIR = @"\finalfibbage\";


        private string FInstallDir;
        private QuestionsParser FParser;
        private QuestionsParser FTransParser;
        private MultiTranslateData FShortieTransData;
        private MultiTranslateData FFinalTransData;
        public FibbageData(string aInstallDir)
        {
            FInstallDir = aInstallDir;
            FParser = new QuestionsParser(GetContentDir());
            FTransParser = new QuestionsParser(GetTranslateDir());
            FShortieTransData = new MultiTranslateData(FParser.ShortieQuestions, FTransParser.ShortieQuestions);
            FFinalTransData = new MultiTranslateData(FParser.FinalQuestions, FTransParser.FinalQuestions);
        }

        public MultiTranslateData GetShortiesToTranslate()
        {
            return FShortieTransData;
        }

        public MultiTranslateData GetFinalToTranslate()
        {
            return FFinalTransData;
        }

        private string GetContentDir()
        {
            if (Directory.Exists(FInstallDir + CONTENT_DIR))
                return FInstallDir + CONTENT_DIR;
            else
                throw new DirectoryNotFoundException("Invalid install path, content directory not found");
        }
        private string GetTranslateDir()
        {
            if (!Directory.Exists(GetContentDir() + TRANSLATE_DIR))
            {
                Directory.CreateDirectory(GetContentDir() + TRANSLATE_DIR);
            }
            return GetContentDir() + TRANSLATE_DIR;
        }

        public void SaveToFile()
        {
            FShortieTransData.SaveToFile(GetTranslateDir() + SHORTIE_DIR);
            FFinalTransData.SaveToFile(GetTranslateDir() + FINALFIBBAGE_DIR);
        }
    }
}
