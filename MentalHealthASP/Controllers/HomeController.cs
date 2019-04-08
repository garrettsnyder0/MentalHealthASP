using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MentalHealthASP.Models;
using MentalHealthASP.Abstract;
using MentalHealthASP.Concrete;

namespace MentalHealthASP.Controllers
{
    public class HomeController : Controller
    {

        private  IAnxietyRepository anxietyRepository;
        private IDepressionRepository depressionRepository;

        public HomeController(IAnxietyRepository anxietyRepository, IDepressionRepository depressionRepository)
        {
            this.anxietyRepository = anxietyRepository;
            this.depressionRepository = depressionRepository;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DepressionTest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DepressionTest(DepressionTest depressionTest)
        {
            depressionTest.testScore = depressionTest.question1 + depressionTest.question2 + depressionTest.question3 +
                                    depressionTest.question4 + depressionTest.question5 + depressionTest.question6 +
                                    depressionTest.question7 + depressionTest.question8 + depressionTest.question9;
            depressionTest.dateTaken = System.DateTime.Now;
            return View("DepressionResults", depressionTest);
        }


        [HttpGet]
        public ActionResult AnxietyTest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AnxietyTest(AnxietyTest anxietyTest)
        {
            anxietyTest.testScore = anxietyTest.question1 + anxietyTest.question2 + anxietyTest.question3 +
                                    anxietyTest.question4 + anxietyTest.question5 + anxietyTest.question6 + anxietyTest.question7;
            anxietyTest.dateTaken = System.DateTime.Now;
            
            

            return View("AnxietyResults", anxietyTest);
        }

        public ActionResult History()
        {
            HistoryViewModel model = new HistoryViewModel
            {
                AnxietyTests = anxietyRepository.AnxietyTests,
                DepressionTests = depressionRepository.DepressionTests,
                
            };
            return View(model);
        }
    }
}