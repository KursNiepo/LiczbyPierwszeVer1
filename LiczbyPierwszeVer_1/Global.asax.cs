﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LiczbyPierwszeVer_1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ClientDataTypeModelValidatorProvider.ResourceClassKey = "Message";
            DefaultModelBinder.ResourceClassKey = "Message";
        }
    }
}
