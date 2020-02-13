﻿using BestApp.Core.Models;
using BestApp.Domain;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using static BestApp.Areas.Api.Controllers.CatsController;

namespace BestApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var builder = new ODataConventionModelBuilder();
            config.Count().Filter().OrderBy().Expand().Select().MaxTop(null);

            builder.EntitySet<Cat>("Cats"); //test //cho su dung odata
            builder.EntitySet<StaffViewModel>("Staffs");
            builder.EntitySet<CourseViewModel>("Courses");

            // Web API routes
            config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
        }
    }
}
