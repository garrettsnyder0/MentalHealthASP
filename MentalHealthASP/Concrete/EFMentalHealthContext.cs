﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MentalHealthASP.Models;

namespace MentalHealthASP.Concrete
{
    public class EFMentalHealthContext : DbContext
    {

        public DbSet<AnxietyTest> AnxietyTests { get; set; }
        public DbSet<DepressionTest> DepressionTests { get; set; }
        public DbContext db;

        public EFMentalHealthContext() : base("EFMentalHealthContext")
        {

        }

       
    }
}