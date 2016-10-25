using OpenQA.Selenium;
using PageObject.Factory.Contracts.Base.Contracts;

namespace PageObject.Factory.Base
{
    /// <summary>
    /// The Page Object base.
    /// </summary>
    /// <seealso cref="PageObject.Factory.Contracts.Base.Contracts.IPageObjectBase" />
    public class PageObjectBase : IPageObjectBase
    {
        /// <summary>
        /// The web driver
        /// </summary>
        protected IWebDriver WebDriver;

        /// <summary>
        /// Initializes a new instance of the <see cref="PageObjectBase"/> class.
        /// </summary>
        /// <param name="webDriver">The web driver.</param>
        public PageObjectBase(IWebDriver webDriver)
        {
            this.WebDriver = webDriver;
        }
    }
}
