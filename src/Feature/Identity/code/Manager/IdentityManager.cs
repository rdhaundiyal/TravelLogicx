using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelLogicx.Feature.Identity.Model;
using TravelLogicx.Feature.Identity.Repositories;
using Sitecore;
using Sitecore.Data.Items;
using TravelLogicx.Foundation.SitecoreExtensions.Extensions;
namespace TravelLogicx.Feature.Identity.Manager
{
    public class IdentityManager:IIdentityManager
    {
        private IdentityRepository _identityRepository;
        public IdentityManager(IdentityRepository identityRepository)
        {
            _identityRepository = identityRepository;

        }
        public IdentityDetails GetIdentityDetails(Item item)
        {
            var siteRootItem = item.GetAncestorOrSelfOfTemplate(Templates.ID);

            return _identityRepository.GetItem(siteRootItem);
        }
    }
}