using System.ComponentModel.DataAnnotations;

namespace MentalHealthASP.Models
{
    using System;
    using System.Collections.Generic;
    

    public partial class AnxietyTest
    {
        public int testScore { get; set; }
        [Key]
        public System.DateTime dateTaken { get; set; }
        public string comments { get; set; }
        public int question1 { get; set; }
        public int question2 { get; set; }
        public int question3 { get; set; }
        public int question4 { get; set; }
        public int question5 { get; set; }
        public int question6 { get; set; }
        public int question7 { get; set; }
    }
}
