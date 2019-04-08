using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MentalHealthASP.Models;

namespace MentalHealthASP.Abstract
{
    public interface IDepressionRepository
    {
        IEnumerable<DepressionTest> DepressionTests { get; }
    }
}
