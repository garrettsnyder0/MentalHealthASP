using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MentalHealthASP.Abstract;
using MentalHealthASP.Models;

namespace MentalHealthASP.Concrete
{
    public class EFAnxietyRepository : IAnxietyRepository
    {
        public EFMentalHealthContext context = new EFMentalHealthContext();

        public IEnumerable<AnxietyTest> AnxietyTests
        {
            get { return context.AnxietyTests.AsNoTracking(); }
        }
    }
}