using Autofac;
using Autofac.Integration.Mvc;
using Student.Application.Service;
using Student.Core.IRepository;
using Student.EntityFramework;
using Student.EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student.WebApp.App_Start
{
    public class IoCConfig
    {
        public static IContainer RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterAssemblyTypes(typeof(StudentService).Assembly).Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<StudentDBContext>().InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));

            IContainer container = builder.Build();

            return container;
        }
    }
}