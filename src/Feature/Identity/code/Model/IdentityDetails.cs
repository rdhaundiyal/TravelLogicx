using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelLogicx.Foundation.Base.Model;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;
namespace TravelLogicx.Feature.Identity.Model
{
    [SitecoreType]
    public class IdentityDetails : GlassBase
    {

        [SitecoreField]
        public string Title { get; set; }
        public Image Logo { get; set; }
        [SitecoreField("Logo Tagline")]
        public string LogoTagline { get; set; }
        [SitecoreField]
        public string Copyright { get; set; }
        [SitecoreField]
        public string OrganizationName { get; set; }
        [SitecoreField]
        public string OrganizationAddress { get; set; }
        [SitecoreField]
        public string OrganizationPhone { get; set; }
        [SitecoreField(FieldType = SitecoreFieldType.GeneralLink)]
       public Link OrganizationEmail { get; set; }
    }
}