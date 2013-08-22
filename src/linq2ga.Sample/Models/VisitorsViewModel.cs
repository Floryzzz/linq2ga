﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace linq2ga.Sample.Models
{
    public class VisitorsDataViewModel
    {
        public int TotalVisitors { get; set; }

        public List<VisitorsByCountryModel> VisitorsByCountries { get; set; }
    }
}