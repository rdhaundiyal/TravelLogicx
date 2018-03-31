using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelLogicx.Feature.Identity.Model;
using TravelLogicx.Foundation.Base.Repositories;

namespace TravelLogicx.Feature.Identity.Repositories
{
   public interface IIdentityRepository:IBaseRepository<IdentityDetails>
    {
    }
}
