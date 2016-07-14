using Microsoft.ApplicationInsights;
using System;
using System.Web.Mvc;

namespace KV.SampleAplicationInsights.Code
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class AiHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext != null && filterContext.HttpContext != null && filterContext.Exception != null)
            {
                // Note: A single instance of telemetry client is sufficient to track multiple telemetry items.
                var ai = new TelemetryClient();
                ai.TrackException(filterContext.Exception);
            }

            base.OnException(filterContext);
        }
    }
}