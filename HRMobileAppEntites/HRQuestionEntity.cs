using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMobileAppEntites
{
    public class HRQuestionEntity
    {
        public int ID { get; set; }
        public int TechCategoryID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int Rank { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
