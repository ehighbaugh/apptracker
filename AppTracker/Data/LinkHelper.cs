using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppTracker.Data
{
    public static class LinkHelper
    {
        public static string ExternalLink(this HtmlHelper helper, string url, string text)
        {
            return String.Format("<a href='http://{0}' target='_blank'>{1}</a>", url, text);
        }
    }
}