﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        public object GridViewDataSource
        {
            set
            {
                GridViewControl2.BindGridViewData(value);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}