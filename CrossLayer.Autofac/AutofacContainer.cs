using Autofac;
using PageObject.Factory.Contracts.Pages.Contracts;
using PageObject.Factory.Pages;
using PageObject.SauceLabs.Factory.Pages;

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
            AutofacContainerSelenium();
            // AutofacContainerSauceLabs();
        }

        private static void AutofacContainerSelenium()
        {
            var buildContainer = new ContainerBuilder();
            buildContainer.RegisterType<HomePage>().As<IHomePage>();
            buildContainer.RegisterType<ManagerPage>().As<IManagerPage>();
            buildContainer.RegisterType<NewCustomerPage>().As<INewCustomerPage>();
            buildContainer.RegisterType<CustomerRegisteredPage>().As<ICustomerRegisteredPage>();
            buildContainer.RegisterType<SelectEditCustomerPage>().As<ISelectEditCustomerPage>();
            buildContainer.RegisterType<EditCustomerPage>().As<IEditCustomerPage>();
            buildContainer.RegisterType<NewAccountPage>().As<INewAccountPage>();

            AContainer = buildContainer.Build();
        }

        private static void AutofacContainerSauceLabs()
        {
            var buildContainer = new ContainerBuilder();
            buildContainer.RegisterType<SLHomePage>().As<IHomePage>();
            buildContainer.RegisterType<SLManagerPage>().As<IManagerPage>();
            buildContainer.RegisterType<SLNewCustomerPage>().As<INewCustomerPage>();
            buildContainer.RegisterType<SLCustomerRegisteredPage>().As<ICustomerRegisteredPage>();
            buildContainer.RegisterType<SLSelectEditCustomerPage>().As<ISelectEditCustomerPage>();
            buildContainer.RegisterType<SLEditCustomerPage>().As<IEditCustomerPage>();
            buildContainer.RegisterType<SLNewAccountPage>().As<INewAccountPage>();

            AContainer = buildContainer.Build();
        }
    }
}
