using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace AKB.MVC5.HtmlHelperExtensions.MVC5.HelperExtensions.Componets.Helper.StringBuilderr.Extension
{
    public static class BootstrapRadioButtonHelper
    {
        public static MvcHtmlString BootstrapRadioButtonFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression,
           string text, object htmlAttributes = null)
        {
            return BootstrapRadioButtonFor(htmlHelper, expression, text, string.Empty, false, false, htmlAttributes);
        }

        public static MvcHtmlString BootstrapRadioButtonFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression,
           string text, string title, bool isAutoFocous, object htmlAttributes = null)
        {
            return BootstrapRadioButtonFor(htmlHelper, expression, text, title, isAutoFocous, false, htmlAttributes);
        }

        public static MvcHtmlString BootstrapRadioButtonFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, bool>> expression,
            string text, string title, bool isAutoFocous, bool isInline, object htmlAttributes = null)
        {
            StringBuilder sb = new StringBuilder();
            RouteValueDictionary rvd;

            rvd = new RouteValueDictionary(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            if (string.IsNullOrWhiteSpace(title))
            {
                title = text;
            }
            rvd.Add("title", title);
            if (isAutoFocous)
            {
                rvd.Add("autofocus", "autofocus");
            }

            //open the Radio element
            if (isInline)
            {
                sb.Append("<label class='radio-inline'>");
            }
            else
            {
                sb.Append("<div class='radio'>");
                sb.Append("<label>");
            }

            //Build the Radio using the InputExtension Class
            sb.Append(InputExtensions.RadioButtonFor(htmlHelper, expression, rvd));
            //Add the Text
            sb.Append(text);
            //Close the Radio element
            if (isInline)
            {
                sb.Append("</label>");
            }
            else
            {
                sb.Append("</label>");
                sb.Append("</div>");
            }


            return MvcHtmlString.Create(sb.ToString());
        }
    }
}
