using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelLogicx.Feature.Identity.Manager;
using TravelLogicx.Feature.Identity.Repositories;
using TravelLogicx.Foundation.SitecoreExtensions.Extensions;
namespace TravelLogicx.Feature.Identity.Controllers
{
    public class IdentityController : Controller
    {
        private IIdentityManager _identityManager;

        public IdentityController(IIdentityManager identityManager)
        {
            _identityManager = identityManager;
        }
        // GET: Identity
        public ActionResult SiteIdentity()
        {
            
            var currentItem=Sitecore.Context.Item;
            var siteIdentity = _identityManager.GetIdentityDetails(currentItem);
                       return View(siteIdentity);
        }
        public ActionResult Logo()
        {
            return View();
        }
    }
}