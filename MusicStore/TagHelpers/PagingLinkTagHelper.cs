using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures; // [ViewContext] attribute
using Microsoft.AspNetCore.Mvc.Rendering; // ViewContext data type
using Microsoft.AspNetCore.Routing; // LinkGenerator
using MusicStore.Models;

namespace MusicStore.TagHelpers
{
    [HtmlTargetElement("my-paging-link")]
    public class PagingLinkTagHelper : TagHelper
    {
        private LinkGenerator linkBuilder;
        public PagingLinkTagHelper(LinkGenerator lg) => linkBuilder = lg;

        [ViewContext] [HtmlAttributeNotBound] public ViewContext ViewCtx { get; set; }

        public string Type { get; set; }
        public RouteDictionary Current { get; set; }

        public int Pages { get; set; }

        public override void Process(TagHelperContext context,
            TagHelperOutput output)
        {
            // update routes for this paging link
            var routes = Current.Clone();
            routes.PageNumber = Type switch
            {
                "previous" => Current.PageNumber - 1,
                "next" => Current.PageNumber + 1,
                _ => routes.PageNumber
            };

            // get controller and action method, create paging link URL
            string ctlr = ViewCtx.RouteData.Values["controller"].ToString();
            string action = ViewCtx.RouteData.Values["action"].ToString();
            string url = linkBuilder.GetPathByAction(action, ctlr, routes);

            // build up CSS string
            string linkClasses = "btn btn-outline-warning m-2";
            if (Type == "page")
                linkClasses += " active";


            output.BuildLink(url, linkClasses);

            if (Type == "previous")
            {
                if (Current.PageNumber > 1)
                {
                    output.Content.SetContent("Previous");
                } else
                {
                    output.SuppressOutput();
                }
            }

            else if (Type == "next")

            {
                if (Current.PageNumber < Pages)
                {
                    output.Content.SetContent("Next");
                } else
                {
                    output.SuppressOutput();
                }
            }
            else
            {
                // create link
                output.BuildLink(url, linkClasses);
                output.Content.SetContent($"{Current.PageNumber} of {Pages}");
            }
        }
    }
}