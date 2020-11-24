using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbageQEdit
{
    public class FibbageShortieJSON
    {
        public List<Content> content { get; set; }
        public int episodeid { get; set; }
    }

    public class Content
    {
        public bool x { get; set; }
        public int id { get; set; }
        public string category { get; set; }
        public string bumper { get; set; }
    }
}
