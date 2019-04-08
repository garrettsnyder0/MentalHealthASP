using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MentalHealthASP.Models
{
    public class HistoryViewModel
    {
        public IEnumerable<AnxietyTest> AnxietyTests { get; set; }
        public IEnumerable<DepressionTest> DepressionTests { get; set; }
    }
}