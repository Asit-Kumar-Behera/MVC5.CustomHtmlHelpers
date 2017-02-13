using AKB.MVC5.HtmlHelperExtensions.MVC5.HelperExtensions.Componets.MVC5.Components.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AKB.MVC5.HtmlHelperExtensions.MVC5.HelperExtensions.Componets.Helper.StringBuilderr.Extension
{
    public static class BootstrapButtonHelper
    {
        /// <summary>
        /// Bootstrap Submit Button Helper
        /// </summary>
        /// <param name="htmlHelper">The helper</param>
        /// <param name="innerHtml">The text (or HTML) for the button</param>
        /// <param name="htmlAttributes">An object that sets the HTML attributes for the element (optional)</param>
        /// <returns>A HTML &lt;button&gt; element with the appropriate properties set.</returns>
        public static MvcHtmlString BootstrapButton(this HtmlHelper htmlHelper,
                      string innerHtml,
                      object htmlAttributes = null)
        {
            return BootstrapButton(htmlHelper, innerHtml, null, null, null, false, false, HtmlHelperExtensionsCommon.HtmlButtonTypes.submit, htmlAttributes);
        }

        /// <summary>
        /// Bootstrap Submit Button Helper
        /// </summary>
        /// <param name="htmlHelper">The helper</param>
        /// <param name="innerHtml">The text (or HTML) for the button</param>
        /// <param name="cssClass">CSS class(es) to add</param>
        /// <param name="htmlAttributes">An object that sets the HTML attributes for the element (optional)</param>
        /// <returns>A HTML &lt;button&gt; element with the appropriate properties set.</returns>
        public static MvcHtmlString BootstrapButton(this HtmlHelper htmlHelper,
                  string innerHtml,
                  string cssClass,
                  object htmlAttributes = null)
        {
            return BootstrapButton(htmlHelper, innerHtml, cssClass, null, null, false, false, HtmlHelperExtensionsCommon.HtmlButtonTypes.submit, htmlAttributes);
        }

        /// <summary>
        /// Bootstrap Submit Button Helper
        /// </summary>
        /// <param name="htmlHelper">The helper</param>
        /// <param name="innerHtml">The text (or HTML) for the button</param>
        /// <param name="cssClass">CSS class(es) to add</param>
        /// <param name="name">The 'name' attribute for this element</param>
        /// <param name="htmlAttributes">An object that sets the HTML attributes for the element (optional)</param>
        /// <returns>A HTML &lt;button&gt; element with the appropriate properties set.</returns>
        public static MvcHtmlString BootstrapButton(this HtmlHelper htmlHelper, string innerHtml, string cssClass, string name, object htmlAttributes = null)
        {
            return BootstrapButton(htmlHelper, innerHtml, cssClass, name, null, false, false, HtmlHelperExtensionsCommon.HtmlButtonTypes.submit, htmlAttributes);
        }

        /// <summary>
        /// Bootstrap submit button helper
        /// </summary>
        /// <param name="helper">The helper</param>
        /// <param name="innerHtml">The text (or HTML) for the button</param>
        /// <param name="cssClass">CSS class(es) to add to the button</param>
        /// <param name="name">The 'name' attributes for the button</param>
        /// <param name="title">The 'title' attribute for the button</param>
        /// <param name="isFormNoValidate">Whether or not this button validates the form</param>
        /// <param name="isAutoFocous">Whether or not this button gets the input focus</param>
        /// <param name="buttonType">The 'type' of button. Can be 'submit', 'reset', or 'button')</param>
        /// <param name="htmlAttributes">An object that sets the HTML attributes for the element (optional)</param>
        /// <returns>A HTML button element with the appropriate properties set.</returns>
        public static MvcHtmlString BootstrapButton(this HtmlHelper helper, string innerHtml, string cssClass, string name, string title, bool isFormNoValidate, bool isAutoFocous, HtmlHelperExtensionsCommon.HtmlButtonTypes buttonType, object htmlAttributes = null)
        {
            //create a TagBuilder for the Button
            TagBuilder tb = new TagBuilder("button");

            //Check for we have btn-* class for the button
            if (!string.IsNullOrEmpty(cssClass))
            {
                if (cssClass.Contains("btn-"))
                {
                    cssClass = "btn-primary" + cssClass;
                }
            }
            else
            {
                cssClass = "btn-primary";
            }

            //Add additional css classes to the Button
            tb.AddCssClass(cssClass);

            tb.AddCssClass("btn");

            //Add name and id attributes of the button if present

            HtmlHelperExtensionsCommon.AddName(tb, name, null);

            //Adding HTML 5 attributes
            if (!string.IsNullOrEmpty(title))
            {
                tb.MergeAttribute("title", title);
            }

            if (isFormNoValidate)
            {
                tb.MergeAttribute("formnovalidate", "formnovalidate");
            }

            if (isAutoFocous)
            {
                tb.MergeAttribute("autofocus", "autofocus");
            }

            //set inner html of the button

            tb.InnerHtml = innerHtml;

            //Add button type
            switch (buttonType)
            {
                case HtmlHelperExtensionsCommon.HtmlButtonTypes.submit:
                    tb.MergeAttribute("type", "submit");
                    break;
                case HtmlHelperExtensionsCommon.HtmlButtonTypes.button:
                    tb.MergeAttribute("type", "button");
                    break;
                case HtmlHelperExtensionsCommon.HtmlButtonTypes.reset:
                    tb.MergeAttribute("type", "reset");
                    break;
            }

            //Add additional html attributes
            tb.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            return MvcHtmlString.Create(tb.ToString());
        }
    }
}
