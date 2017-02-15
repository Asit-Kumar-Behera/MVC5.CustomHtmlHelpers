using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AKB.MVC5.HtmlHelperExtensions.MVC5.HelperExtensions.Componets.MVC5.Components.Common
{
    public static class HtmlHelperExtensionsCommon
    {
        public enum HtmlButtonTypes
        {
            submit,
            button,
            reset
        }

        public enum Html5InputTypes
        {
            text,
            password,
            color,
            date,
            datetime,
            email,
            month,
            number,
            range,
            search,
            tel,
            time,
            url,
            week
        }
        public static void AddName(TagBuilder tb, string name, string id)
        {
            //Check for name is present
            if (!string.IsNullOrEmpty(name))
            {
                //check for valid name
                name = TagBuilder.CreateSanitizedId(name);
                if (string.IsNullOrWhiteSpace(id))
                {
                    //Generate valid 'id' attribute
                    //from the 'name' attribute of the button
                    tb.GenerateId(name);
                }
                else
                {
                    //Add 'id' attributes to button
                    tb.MergeAttribute("id", TagBuilder.CreateSanitizedId(id));
                }
            }
            tb.MergeAttribute("name", name);
        }
    }
}
