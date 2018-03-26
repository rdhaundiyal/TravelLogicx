using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelLogicx.Foundation.SitecoreExtensions.Extensions;
namespace TravelLogicx.Feature.Identity.Controllers
{
    public class IdentityController : Controller
    {
        // GET: Identity
        public ActionResult SiteIdentity()
        {
            var item=Sitecore.Context.Item;
            var rootItem = item.GetAncestorOrSelfOfTemplate(Templates.ID);
            return View();
        }
        public ActionResult Logo()
        {
            return View();
        }
    }
}