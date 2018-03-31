//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using Sitecore.Mvc;
//using Sitecore.Mvc.Data;
//using Sitecore.Data;
//using Sitecore.Data.Items;
//using Sitecore.Mvc.Helpers;

//namespace code.Extensions
//{
//    public static class SitecoreExtensions
//    {
//        public static string Dictionary(this SitecoreHelper helper, string relativePath, string defaultValue = "")
//        {
//            return DictionaryPhraseRepository.Current.Get(relativePath, defaultValue);
//        }

//        public static HtmlString DictionaryField(this SitecoreHelper helper, string relativePath, string defaultValue = "")
//        {
//            var item = DictionaryPhraseRepository.Current.GetItem(relativePath, defaultValue);
//            if (item == null)
//                return new HtmlString(defaultValue);
//            return helper.Field(Templates.DictionaryEntry.Fields.Phrase, item);
//        }
//    }
//}