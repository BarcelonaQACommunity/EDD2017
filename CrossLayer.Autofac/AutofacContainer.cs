using Autofac;
using PageObject.Factory.Contracts.Pages.Contracts;
using PageObject.Factory.Pages;

namespace CrossLayer.Autofac
{
    /// <summary>
    /// Autofac Container.
    /// </summary>
    public static class AutofacContainer
    {
        /// <summary>
        /// Gets the container.
        /// </summary>
        public static IContainer AContainer { get; private set; }

        /// <summary>
        /// Initializes the <see cref="AutofacContainer"/> class.
        /// </summary>
        static AutofacContainer()
        {
            var buildContainer = new ContainerBuilder();
            buildContainer.RegisterType<HomePage>().As<IHomePage>();
            buildContainer.RegisterType<ManagerPage>().As<IManagerPage>();
            buildContainer.RegisterType<NewCustomerPage>().As<INewCustomerPage>();
            buildContainer.RegisterType<CustomerRegisteredPage>().As<ICustomerRegisteredPage>();
            buildContainer.RegisterType<SelectEditCustomerPage>().As<ISelectEditCustomerPage>();
            buildContainer.RegisterType<EditCustomerPage>().As<IEditCustomerPage>();

            AContainer = buildContainer.Build();
        }
    }
}
