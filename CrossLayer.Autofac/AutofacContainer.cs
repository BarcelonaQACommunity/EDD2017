using Autofac;
using PageObject.Factory.Contracts.Pages.Contracts;
using PageObject.Factory.Pages;

namespace CrossLayer.Autofac
{
    /// <summary>
    /// IoC Container.
    /// </summary>
    public static class AutofacContainer
    {
        /// <summary>
        /// Gets the build container.
        /// </summary>
        /// <value>
        /// The build container.
        /// </value>
        public static ContainerBuilder BuildContainer { get; }

        /// <summary>
        /// Initializes the <see cref="AutofacContainer"/> class.
        /// </summary>
        static AutofacContainer()
        {
            BuildContainer = new ContainerBuilder();
            BuildContainer.RegisterType<HomePage>().As<IHomePage>();
        }
    }
}
