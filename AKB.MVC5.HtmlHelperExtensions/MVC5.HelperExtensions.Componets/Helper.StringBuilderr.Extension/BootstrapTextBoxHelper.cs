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
        public static MvcHtmlString BootstrapTextBoxFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TValue>> expression,
            MVC5.Components.Common.HtmlHelperExtensionsCommon.Html5InputTypes type,
            object htmlAttributes = null)
        {
            return BootstrapTextBoxFor(htmlHelper,
              expression, type, string.Empty, string.Empty, false, false,
              string.Empty, htmlAttributes);
        }

        public static MvcHtmlString BootstrapTextBoxFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TValue>> expression,
            MVC5.Components.Common.HtmlHelperExtensionsCommon.Html5InputTypes type,
            string cssClass,
            object htmlAttributes = null)
        {
            return BootstrapTextBoxFor(htmlHelper,
              expression, type, string.Empty, string.Empty, false, false,
              cssClass, htmlAttributes);
        }

        public static MvcHtmlString BootstrapTextBoxFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TValue>> expression,
            MVC5.Components.Common.HtmlHelperExtensionsCommon.Html5InputTypes type,
            string title,
            string placeholder,
            bool isRequired,
            bool isAutoFocus,
            object htmlAttributes = null)
        {
            return BootstrapTextBoxFor(htmlHelper,
              expression, type, title, placeholder, isRequired, isAutoFocus,
              string.Empty, htmlAttributes);
        }

        public static MvcHtmlString BootstrapTextBoxFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TValue>> expression,
            MVC5.Components.Common.HtmlHelperExtensionsCommon.Html5InputTypes type,
            string title,
            string placeHolder,
            bool isRequired,
            bool isAutoFocous,
            string cssClass,
            object htmlAttributes = null)
        {
            RouteValueDictionary rvd;

            rvd = new RouteValueDictionary(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            //Add all other attributes 

            rvd.Add("type", type.ToString());
            if (!string.IsNullOrEmpty(title))
            {
                rvd.Add("title", title);
            }

            if (!string.IsNullOrEmpty(placeHolder))
            {
                rvd.Add("placeholder", placeHolder);
            }

            if (isRequired)
            {
                rvd.Add("required", "required");
            }
            if (isAutoFocous)
            {
                rvd.Add("autofocus", "autofocus");
            }

            if (string.IsNullOrWhiteSpace(cssClass))
            {
                cssClass = "form-control";
            }
            else
            {
                cssClass = "form-control " + cssClass;
            }
            rvd.Add("class", cssClass);

            return InputExtensions.TextBoxFor(htmlHelper, expression, rvd);

        }
    }
}
