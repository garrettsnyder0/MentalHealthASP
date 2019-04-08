using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MentalHealthASP.Abstract;
using MentalHealthASP.Models;


namespace MentalHealthASP.Concrete
{
    public class EFDepressionRepository : IDepressionRepository
    {
        private EFMentalHealthContext context = new EFMentalHealthContext();

        public IEnumerable<DepressionTest> DepressionTests
        {
            get { return context.DepressionTests.AsNoTracking(); }
        }
    }
}