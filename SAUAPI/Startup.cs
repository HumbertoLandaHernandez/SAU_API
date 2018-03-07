﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using SAUAPI;
[assembly: OwinStartup(typeof(Startup))]
namespace SAUAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder App)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            App.UseCors(CorsOptions.AllowAll);
            App.UseWebApi(config);
        }
    }
}