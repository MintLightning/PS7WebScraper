using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS7WebScraper
{
    internal class CourseExt : Course
    {
        public string Subject { get; set; } = "";
        public int CatalogNum { get; set; }
        public int EnrollmentCap { get; set; }
        public int WaitList { get; set; }
        public int Enrolled { get; set; }
        public int SeatsAvailable { get; set; }
    }
}
