using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace AKB.MVC5.HtmlHelperExtensions.MVC5.HelperExtensions.Componets.Helper.StringBuilderr.Extension
{
    public static class BootstrapTextBoxHelper
    {
        public static MvcHtmlString BootstrapTextBoxFor<TModel,TValue>(this HtmlHelper<TModel> htmlHelper,
            Expression <Func<TModel,TValue>> expression,object htmlAttributes=null)
        {
            RouteValueDictionary rvd;

            rvd = new RouteValueDictionary(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            return InputExtensions.TextBoxFor(htmlHelper, expression, rvd);

        }
    }
}
