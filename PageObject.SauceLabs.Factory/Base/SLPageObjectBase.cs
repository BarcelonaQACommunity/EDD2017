using System;
using OpenQA.Selenium;
using PageObject.Factory.Contracts.Base.Contracts;

namespace PageObject.SauceLabs.Factory.Base
{
    /// <summary>
    /// The Page Object base.
    /// </summary>
    /// <seealso cref="PageObject.Factory.Contracts.Base.Contracts.IPageObjectBase" />
    public class SlPageObjectBase : IPageObjectBase
    {
        /// <summary>
        /// The web driver
        /// </summary>
        protected IWebDriver WebDriver;

        /// <summary>
        /// Initializes a new instance of the <see cref="SlPageObjectBase"/> class.
        /// </summary>
        public SlPageObjectBase()
        {
            this.WebDriver = SetUpWebDriver.SetUpWebDriver.WebDriver;
        }

        /// <summary>
        /// Sets up web driver base.
        /// </summary>
        protected void SetUpWebDriverBase()
        {
            SetUpWebDriver.SetUpWebDriver.SetUpSauceLabsWebDriver(string.Empty);
            this.WebDriver = SetUpWebDriver.SetUpWebDriver.WebDriver;
            this.WebDriver.Manage().Cookies.DeleteAllCookies();
            this.WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// Sets up web driver base.
        /// </summary>
        protected void SetUpWebDriverBase(string currentScenario)
        {
            SetUpWebDriver.SetUpWebDriver.SetUpSauceLabsWebDriver(currentScenario);
            this.WebDriver = SetUpWebDriver.SetUpWebDriver.WebDriver;
            this.WebDriver.Manage().Cookies.DeleteAllCookies();
            this.WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }
    }
}
