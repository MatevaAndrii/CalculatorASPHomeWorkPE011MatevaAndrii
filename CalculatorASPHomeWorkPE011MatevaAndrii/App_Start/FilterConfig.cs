using System.Web;
using System.Web.Mvc;

namespace CalculatorASPHomeWorkPE011MatevaAndrii
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
