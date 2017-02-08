using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AKB.MVC5.HtmlHelperExtensions.MVC5.HelperExtensions.Componets.Helper.StringBuilderr.Extension
{
    public static class StringBuilderImageHtmlHelper
    {
        /// <summary>
        /// Creates basic image html helper method to create image tag with parameter src and alttext 
        /// Creating this helper using StringBuilder class.
        /// </summary>
        /// <param name="htmlHelper">The helper</param>
        /// <param name="src">The source of the picture to display</param>
        /// <param name="altText">The alternate text to display</param>
        /// <returns>A HTML img element with the appropriate properties set</returns>
        public static MvcHtmlString Image(this HtmlHelper htmlHelper, string src, string altText)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<img src='{0}' alt='{1}'/>", src, altText);

            return MvcHtmlString.Create(sb.ToString());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper">The helper</param>
        /// <param name="src">The source of the picture to display</param>
        /// <param name="altText">The alternate text to display</param>
        /// <param name="cssClass">The css classes that to be rendered</param>
        /// <param name="name">The name to display</param>
        /// <param name="htmlAttributes">The anonymous attributes to display</param>
        /// <returns>A HTML img element with the appropriate properties set</returns>
        public static MvcHtmlString Image(this HtmlHelper htmlHelper, string src, string altText, string cssClass, string name, object htmlAttributes = null)
        {
            TagBuilder tagBuilder = new TagBuilder("img");
            tagBuilder.MergeAttribute("src", src);
            tagBuilder.MergeAttribute("alt", altText);

            if (!string.IsNullOrEmpty(cssClass))
            {
                tagBuilder.AddCssClass(cssClass);
            }

            if (!string.IsNullOrEmpty(name))
            {
                //This will create a valid name if there is a space it will convert it to _
                name = TagBuilder.CreateSanitizedId(name);
                //create a id with name
                tagBuilder.GenerateId(name);
                tagBuilder.MergeAttribute("name", name);
            }

            //merging all the anonymous attributes of the element (new{@onclick="previewImage()"})
            tagBuilder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            //Html Encode to the string
            return MvcHtmlString.Create(tagBuilder.ToString(TagRenderMode.SelfClosing));
        }
    }
}
