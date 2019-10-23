using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_Http2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

      //  [ActionName("server-push")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

  
    }

    public static class PushPromiseExtensions
    {
        public static IHtmlString PushPromiseStylesheet(this HtmlHelper htmlHelper, string contentPath)
        {
            UrlHelper urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);

            htmlHelper.ViewContext.RequestContext.HttpContext.Response.PushPromise(contentPath);

            TagBuilder linkTagBuilder = new TagBuilder("link");
            linkTagBuilder.Attributes.Add("rel", "stylesheet");
            linkTagBuilder.Attributes.Add("href", urlHelper.Content(contentPath));

            return new HtmlString(linkTagBuilder.ToString());
        }
    }
}