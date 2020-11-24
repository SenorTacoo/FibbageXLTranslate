using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbageQEdit
{
    class TranslateData
    {
        private FibbaggeQuestionJSON FOrgQuestion;
        private FibbaggeQuestionJSON FTranslatedQuestion;
        public TranslateData(FibbaggeQuestionJSON aOrgQuestion, FibbaggeQuestionJSON aTranslatedQuestion)
        {
            FOrgQuestion = aOrgQuestion;
            if (aTranslatedQuestion == null)
            {
                FTranslatedQuestion = FOrgQuestion.CloneForTranslate();
                FTranslatedQuestion.id = FOrgQuestion.id;
            } else
            {
                FTranslatedQuestion = aTranslatedQuestion;
            }
        }

        public string OriginalQuestion
        {
            get { return FOrgQuestion.Question;  }
        }

        public string TranslatedQuestion
        {
            get { return FTranslatedQuestion.Question;  }
            set { FTranslatedQuestion.Question = value; }
        }

        public string OriginalSuggestion
        {
            get { return FOrgQuestion.Suggestions.Replace(",", ", "); }
        }

        public string TranslatedSuggestion
        {
            get { return FTranslatedQuestion.Suggestions.Replace(",", ", "); }
            set { FTranslatedQuestion.Suggestions = value.Replace(", ", ","); }
        }

        public string OriginalCorrectAnswer
        {
            get { return FOrgQuestion.CorrectAnswer; }
        }

        public string TranslatedCorrectAnswer
        {
            get { return FTranslatedQuestion.CorrectAnswer; }
            set { FTranslatedQuestion.CorrectAnswer = value; }
        }

        public string OriginalAlternateSpelling
        {
            get { return FOrgQuestion.AlternateSpelling.Replace(",", ", "); }
        }

        public string TranslatedAlternateSpelling
        {
            get { return FTranslatedQuestion.AlternateSpelling.Replace(",", ", "); }
            set { FTranslatedQuestion.AlternateSpelling = value.Replace(", ", ","); }
        }

        public string Id
        {
            get { return FTranslatedQuestion.id; }
        }

        public FibbaggeQuestionJSON TranslatedData
        {
            get { return FTranslatedQuestion; }
        }
    }
}
