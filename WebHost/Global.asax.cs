﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;

namespace WebHost
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            
            GlobalConfiguration.Configuration.Routes.MapHttpRoute("DefaultAPI",
                "api/{controller}/{id}",
                new { controller = "Contact", id = RouteParameter.Optional });
        }
    }
}