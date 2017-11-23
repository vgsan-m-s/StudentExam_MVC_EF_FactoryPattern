using Autofac;
using Microsoft.Owin;
using Owin;
using Student.Application;
using Student.WebApp.App_Start;
using System.Web.Mvc;

[assembly: OwinStartupAttribute(typeof(Student.WebApp.Startup))]
namespace Student.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            IContainer container = IoCConfig.RegisterDependencies();
            DependencyResolver.SetResolver(new Autofac.Integration.Mvc.AutofacDependencyResolver(container));

            //Auto mapper registration
            AutoMapperWebConfiguration.Configure();

            ConfigureAuth(app);
        }
    }
}
