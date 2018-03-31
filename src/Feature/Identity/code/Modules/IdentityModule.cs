using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelLogicx.Feature.Identity.Manager;
using TravelLogicx.Feature.Identity.Model;
using TravelLogicx.Feature.Identity.Repositories;
using TravelLogicx.Foundation.Base.Repositories;

namespace TravelLogicx.Feature.Identity.Modules
{
    public class IdentityModule : Module
    {
        protected override void Load(ContainerBuilder builder)

        {
            builder.RegisterType<IdentityManager>().As<IIdentityManager>();
            builder.RegisterType<IdentityRepository>().As<IBaseRepository<IdentityDetails>>();
        }
    }
}