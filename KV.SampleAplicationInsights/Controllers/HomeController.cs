using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace KV.SampleAplicationInsights.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult ThrowException()
        {
            throw new Exception("Exception : " + DateTime.Now.ToLongTimeString());
        }

        /// <summary>
        /// Custom Events: Track events to count occurrences and allow you to see the details of specific instances. 
        /// On the server side, track business events such as sales, game results or poison pill messages. 
        /// On the client side, track user actions to understand usage patterns.
        /// 
        /// Custom Metrics: Track any continuous measurement. Use metrics when you care about aggregations over time. 
        /// They are multi-dimensional so you can have a metric for fruits sold, with dimensions like color, weight, type and so on. 
        /// For instance, with a multi-dimensional metric you can analyze the number of red Fuji apples sold over a day from a particular zip code.
        /// </summary>
        /// <param name="nameEvent"></param>
        /// <returns></returns>
        public ActionResult TrackEvent(string eventName)
        {
            var tc = new TelemetryClient();
            
            var properties = new Dictionary<string, string> { { "Game", "GameName" }, { "Difficulty", "Hard" } };
            var measurements = new Dictionary<string, double> { { "GameScore", 20 }, { "Opponents", 1 } };

            tc.TrackEvent(eventName, properties, measurements);

            ViewBag.EventName = eventName;

            return View();
        }
    }
}