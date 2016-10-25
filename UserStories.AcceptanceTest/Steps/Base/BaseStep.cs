using Autofac;

namespace UserStories.AcceptanceTest.Steps.Base
{
    /// <summary>
    /// The base step.
    /// </summary>
    public class BaseStep
    {
        /// <summary>
        /// Gets or sets the container.
        /// </summary>
        protected IContainer Container { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseStep"/> class.
        /// </summary>
        /// <param name="containerBuilder">The container builder.</param>
        public BaseStep(ContainerBuilder containerBuilder)
        {
            this.Container = containerBuilder.Build();
        }
    }
}
