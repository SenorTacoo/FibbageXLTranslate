using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FibbageQEdit
{
    class QuestionsParser
    {

        private const string FINALFIBBAGE = @"\finalfibbage.jet";
        private const string SHORTIE_DIR = @"\fibbageshortie\";
        private const string FINALFIBBAGE_DIR = @"\finalfibbage\";
        private const string DATA_FILE = @"\data.jet";

        private string FContentDir;
        private FibbageShortieJSON FShortie;
        private List<FibbaggeQuestionJSON> FShortieQuestions = new List<FibbaggeQuestionJSON>();
        private List<FibbaggeQuestionJSON> FFinalQuestions = new List<FibbaggeQuestionJSON>();

        public QuestionsParser(string aContentDir)
        {
            FContentDir = aContentDir;
            PrepareShortie();

            PrepareShortieQuestions();

            PrepareFinalQuestions();
        }

        private void PrepareShortie()
        {
            var json = "";
            try
            {
                json = File.ReadAllText(FContentDir + FINALFIBBAGE);
            }
            catch (FileNotFoundException e)
            {

            }
            FShortie = JsonConvert.DeserializeObject<FibbageShortieJSON>(json);
        }

        private void PrepareShortieQuestions()
        {
            var json = "";
            try
            {
                var questionFiles = Directory.GetDirectories(FContentDir + SHORTIE_DIR);
                var encoding = new UTF8Encoding(false);
                foreach (var dir in questionFiles)
                {
                    try
                    {
                        json = File.ReadAllText(dir + DATA_FILE, encoding);
                        var newObj = JsonConvert.DeserializeObject<FibbaggeQuestionJSON>(json);
                        newObj.id = Path.GetFileNameWithoutExtension(dir);
                        FShortieQuestions.Add(newObj);
                    }
                    catch (FileNotFoundException)
                    {

                    }
                }
            }
            catch (DirectoryNotFoundException e)
            {

            }
        }

        private void PrepareFinalQuestions()
        {
            var json = "";
            try
            {
                var questionFiles = Directory.GetDirectories(FContentDir + FINALFIBBAGE_DIR);
                var encoding = new UTF8Encoding(false);
                foreach (var dir in questionFiles)
                {
                    json = File.ReadAllText(dir + DATA_FILE, encoding);
                    var newObj = JsonConvert.DeserializeObject<FibbaggeQuestionJSON>(json);
                    newObj.id = Path.GetFileNameWithoutExtension(dir);
                    FFinalQuestions.Add(newObj);
                }
            }
            catch (DirectoryNotFoundException e)
            {

            }
        }

        public List<FibbaggeQuestionJSON> ShortieQuestions
        {
            get { return FShortieQuestions; }
        }

        public List<FibbaggeQuestionJSON> FinalQuestions
        {
            get { return FFinalQuestions; }
        }
    }
}
