using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using TravelLogicx.Foundation.Base.Model;

namespace TravelLogicx.Foundation.Base.Repositories
{
    public abstract class BaseRepository<T> where T:GlassBase
    {
        protected T GetItem(string path = "")
        {
            using (var context = new SitecoreContext())
            {
                return string.IsNullOrEmpty(path) ? context.GetCurrentItem<T>() : context.GetItem<T>(path);
            }
        }
        protected T GetItem(Item item) 
        {
            using (var context = new SitecoreContext())
            {
                return context.Cast<T>(item);
            }
        }
    }
}