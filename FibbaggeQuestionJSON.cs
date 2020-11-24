using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbageQEdit
{
    public class FibbaggeQuestionJSON
    {

        private readonly int SUGGESTIONS_INDEX = 4;
        private readonly int CORR_ANSWER_INDEX = 6;
        private readonly int QUESTION_INDEX = 8;
        private readonly int ALT_SPELLING_INDEX = 9;
        private readonly int SUPPORTED_FIELDS_COUNT = 13;

        public List<Field> fields { get; set; }

        [JsonIgnore]
        public string id { get; set; }

        [JsonIgnore]
        public string Question
        {

            get
            {
                if (fields.Count != SUPPORTED_FIELDS_COUNT)
                {
                    throw new NotSupportedException("Fields != 13 not supported");
                } else
                {
                    return fields[QUESTION_INDEX].v;
                }
            }

            set
            {
                fields[QUESTION_INDEX].v = value;
            }
        }

        [JsonIgnore]
        public string CorrectAnswer
        {
            get
            {
                if (fields.Count != SUPPORTED_FIELDS_COUNT)
                {
                    throw new NotSupportedException("Fields != 13 not supported");
                }
                else
                {
                    return fields[CORR_ANSWER_INDEX].v;
                }
            }

            set
            {
                fields[CORR_ANSWER_INDEX].v = value;
            }
        }

        [JsonIgnore]
        public string Suggestions
        {
            get
            {
                if (fields.Count != SUPPORTED_FIELDS_COUNT)
                {
                    throw new NotSupportedException("Fields != 13 not supported");
                }
                else
                {
                    return fields[SUGGESTIONS_INDEX].v;
                }
            }

            set
            {
                fields[SUGGESTIONS_INDEX].v = value;
            }
        }

        [JsonIgnore]
        public string AlternateSpelling
        {
            get
            {
                if (fields.Count != SUPPORTED_FIELDS_COUNT)
                {
                    throw new NotSupportedException("Fields != 13 not supported");
                }
                else
                {
                    return fields[ALT_SPELLING_INDEX].v;
                }
            }

            set
            {
                fields[ALT_SPELLING_INDEX].v = value;
            }
        }

        public FibbaggeQuestionJSON CloneForTranslate()
        {
            var res = new FibbaggeQuestionJSON();
            res.fields = new List<Field>();

            for (int i = 0; i < fields.Count; i++)
            {
                var newField = new Field();
                newField.n = fields[i].n;
                newField.t = fields[i].t;
                if (ShouldSkipEntry(i))
                {
                    newField.v = "";
                } else
                {
                    newField.v = fields[i].v;
                }
                res.fields.Add(newField);
            }
            return res;
        }

        private bool ShouldSkipEntry(int aFieldIndex)
        {
            return (aFieldIndex == SUGGESTIONS_INDEX) || (aFieldIndex == CORR_ANSWER_INDEX) || (aFieldIndex == QUESTION_INDEX) || (aFieldIndex == ALT_SPELLING_INDEX);    
        }
    }

    public class Field
    {
        public string t { get; set; }
        public string v { get; set; }
        public string n { get; set; }
    }
}
