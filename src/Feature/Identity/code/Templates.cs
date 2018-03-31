using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;
namespace TravelLogicx.Feature.Identity
{
    public struct Templates
    {
        public static readonly ID ID = new ID("{D566D488-2093-4A63-AEA1-562870462266}");

        public struct Fields
        {
            public static readonly ID Logo = new ID("{CEB83E33-522C-4F42-A8D8-857E56FD43DC}");
            public static readonly ID LogoTagLine = new ID("{700932E4-E3F9-461B-A3A2-5E52AD5F7F01}");
            public static readonly ID Copyright = new ID("{A50A6BD3-D61C-48C3-8305-729C2AED5EEE}");
            public static readonly ID OrganisationName = new ID("{2E1EB4F2-611B-4AFD-B053-61FB975DEDBF}");
            public static readonly ID OrganisationAddress = new ID("{FA5B47CB-B553-457C-8FC8-B054CBD17770}");
            public static readonly ID OrganisationPhone = new ID("{6AC09331-3287-47D3-B7D5-10ECD2E042F3}");
            public static readonly ID OrganisationEmail = new ID("{51DA6D69-F1D4-47D3-9021-59D72CA1AD73}");
        }
    }
}