using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data.Items;
using TravelLogicx.Foundation.Base.Model;
namespace TravelLogicx.Foundation.Base.Repositories
{
   public interface IBaseRepository<T> where T:GlassBase
    {
        T GetItem(string path = "");

        T GetItem(Item item);
    }
}
