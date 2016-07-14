using KV.SampleAplicationInsights.Code;
using System.Web.Mvc;

namespace KV.SampleAplicationInsights
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AiHandleErrorAttribute());
        }
    }
}