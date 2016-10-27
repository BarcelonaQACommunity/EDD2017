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
        /// <value>
        /// The build container.
        /// </value>
        public static IContainer AContainer { get; }

        /// <summary>
        /// Initializes the <see cref="AutofacContainer"/> class.
        /// </summary>
        static AutofacContainer()
        {
            var buildContainer = new ContainerBuilder();
            buildContainer.RegisterType<HomePage>().As<IHomePage>();
            buildContainer.RegisterType<ManagerPage>().As<IManagerPage>();

            AContainer = buildContainer.Build();
        }
    }
}
