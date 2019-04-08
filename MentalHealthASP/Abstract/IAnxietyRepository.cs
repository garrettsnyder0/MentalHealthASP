using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MentalHealthASP.Models;

namespace MentalHealthASP.Abstract
{
    public interface IAnxietyRepository
    {
        IEnumerable<AnxietyTest> AnxietyTests { get; }
    }
}
