﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jenkinsdotnetprojects
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Opeation(object sender, EventArgs e)
        {
            CalculationProcess objcalculation = new CalculationProcess();
            objcalculation.Add(12, 23);

        }
    }
}