using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using EShop.Models;

namespace EShop.App_Start
{
    public static class DIConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            builder.Register(context => new EShopContext()).As<EShopContext>().InstancePerRequest();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(c => c.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerRequest();
            // OPTIONAL: Enable action method parameter injection (RARE).

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}