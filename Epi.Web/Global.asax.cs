﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Diagnostics;
using System.Configuration;

namespace Epi.Web.MVC
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute
            (
                "{*staticfile}",
                new { staticfile = @".*\.(jpg|gif|jpeg|png|js|css|htm|html|htc)$" }
            );


            routes.MapRoute
            (
                null, // Route name
                "Home/{surveyid}", // URL with parameters
                new { controller = "Home", action = "Index", surveyid = UrlParameter.Optional }
            ); // Parameter defaults

            routes.MapRoute
     (
       null,                                              // Route name
       "Survey/UpdateResponseXml/{id}",                           // URL with parameters
       new { controller = "Survey", action = "UpdateResponseXml", id = "" }
       );  // Parameter defaults


            routes.MapRoute
                (
                    null, // Route name
                    "Survey/{responseid}/{PageNumber}", // URL with parameters
                    new { controller = "Survey", action = "Index", responseid = UrlParameter.Optional, PageNumber = UrlParameter.Optional }
                ); // Parameter defaults



            routes.MapRoute
              (
                  null, // Route name
                  "Login/{responseid}", // URL with parameters
                  new { controller = "Login", action = "Index", responseid = UrlParameter.Optional }
              ); // Parameter defaults
           

            routes.MapRoute
           (
               null, // Route name
               "Final/{surveyid}", // URL with parameters
               new { controller = "Final", action = "Index", surveyid = UrlParameter.Optional }
           ); // Parameter defaults

            routes.MapRoute
            (
              null,                                              // Route name
              "Post/Notify/{id}",                           // URL with parameters
              new { controller = "Post", action = "Notify", id = "" }
              );  // Parameter defaults


        

            routes.MapRoute
           (
             null,                                              // Route name
             "Post/SignOut/{id}",                           // URL with parameters
             new { controller = "Post", action = "SignOut", id = "" }
             );  // Parameter defaults



            routes.MapRoute(
               "Default", // Route name
               "{*url}", // URL with parameters
               new { controller = "Home", action = "Default", id = UrlParameter.Optional }
              );

            //routes.MapRoute
            //(
            //    null, // Route name
            //    "Survey/{surveyid}", // URL with parameters
            //    new { controller = "Survey", action = "ListSurvey", surveyid = UrlParameter.Optional }
            //); // Parameter defaults

            //routes.MapRoute
            //  (
            //      null, // Route name
            //      "Survey/{surveyid}", // URL with parameters
            //      new { controller = "Home", action = "PostSubmit", surveyid = UrlParameter.Optional }
            //  ); // 

        
           

            //routes.MapRoute(
            //   null, // Route name
            //   "{*url}", // URL with parameters
            //   new { controller = "Home", action = "Index", id = UrlParameter.Optional });
            

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            Bootstrapper.Initialise();
        }


        /// <summary>
        ///  HKLM\SYSTEM\CurrentControlSet\services\eventlog needs to be set 
        ///  in order to use the event log
        /// </summary>
        protected void Application_Error()
        {

            Exception exc = Server.GetLastError();

            try
            {
                //string sSource;
                //string sLog;
                string sEvent;

                //sSource = "Epi.Web.Survey";
                //sLog = "Application";
                sEvent = exc.Message + "\n" + exc.StackTrace;


                string s = ConfigurationManager.AppSettings["LOGGING_SEND_EMAIL_NOTIFICATION"];
                if (!String.IsNullOrEmpty(s))
                {
                    if (s.ToUpper() == "TRUE")
                    {
                        s = ConfigurationManager.AppSettings["LOGGING_ADMIN_EMAIL_ADDRESS"];
                        if (!String.IsNullOrEmpty(s))
                        {
                            Epi.Web.Utility.EmailMessage.SendLogMessage(s, "Epi.Web.Survey - Exception", sEvent);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                // do nothing
            }

            this.Response.Redirect("/", true);
        }
    }
}