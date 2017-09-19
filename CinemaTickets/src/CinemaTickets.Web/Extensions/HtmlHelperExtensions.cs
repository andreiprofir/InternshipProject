using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CinemaTickets.Web.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlContent DisplayList(this IHtmlHelper helper, List<string> list)
        {
            if (list == null || list.Count == 0) return new HtmlString("");

            var builder = new StringBuilder();

            int i;
            for (i = 0; i < list.Count - 1; i++)
            {
                builder.Append($"{list[i]}, ");
            }
            builder.Append(list[i]);

            return new HtmlString(builder.ToString());
        }
    }
}