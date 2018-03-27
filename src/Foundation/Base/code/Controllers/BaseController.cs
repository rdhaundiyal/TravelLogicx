﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace TravelLogicx.Foundation.Base.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// return current item if the item path is null or empty else return item for the corresponding path
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>

        protected T GetItem<T>(string path = "") where T : class
        {
            using (var context = new SitecoreContext())
            {
                return string.IsNullOrEmpty(path) ? context.GetCurrentItem<T>() : context.GetItem<T>(path);
            }
        }

        /// <summary>
        /// Returns the DataSource Item specified by the user when Sublayout is added to the page.  If not specified, returns the current item
        /// </summary>
        protected Item DataSourceItemOrCurrentItem
        {
            get
            {
                return RenderingContext.Current.Rendering.Item;
            }
        }

        /// <summary>
        /// Returns the DataSource Item specified by the user when Sublayout is added to the page.  If not specified, returns null
        /// </summary>
        public Item DataSourceItem
        {
            get
            {
                try
                {
                    var str = RenderingContext.Current.Rendering.DataSource;
                    return string.IsNullOrEmpty(str) ? null : RenderingContext.Current.Rendering.Item;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        protected bool IsDataSourceItemNull
        {
            get
            {
                try
                {
                    return string.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource) || RenderingContext.Current.Rendering.Item == null;
                }
                catch (Exception)
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// Wraps the standard sitecore dictionary call.  In order to have all site labels and standard text managed within the CMS, we use the dictionary.
        /// These items simply hold the value for each label.    
        /// </summary>
        /// <param name="key">The dictionary key you are requesting.</param>
        /// <returns>The phrase value for the requested key.</returns>
        protected string GetDictionaryText(string key)
        {
            return Sitecore.Globalization.Translate.Text(key);
        }
    }
}