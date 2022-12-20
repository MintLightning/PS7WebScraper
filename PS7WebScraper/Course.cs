using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS7WebScraper
{
    internal class Course
    {
        public string Title { get; set; } = "";
        public int Credits { get; set; }
        public string Prerequisite { get; set; } = "";
        public string Description { get; set; } = "";
        public List<string> Component { get; set; } = new List<string>();
    }
}
