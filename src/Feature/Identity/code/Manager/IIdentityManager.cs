using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelLogicx.Feature.Identity.Model;

namespace TravelLogicx.Feature.Identity.Manager
{
  public  interface IIdentityManager
    {
         IdentityDetails GetIdentityDetails(Item item);
    }
}
