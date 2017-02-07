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
        public static MvcHtmlString Image(this HtmlHelper htmlHelper,string src,string altText)
        {
            StringBuilder sb = new StringBuilder(512);
            sb.AppendFormat("<img src='{0}' alt='{1}'/>",src,altText);

            return MvcHtmlString.Create(sb.ToString());
        }
    }
}
