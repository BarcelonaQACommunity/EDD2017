using System;
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

        public PageObjectBase()
        {
            this.WebDriver = SetUpWebDriver.SetUpWebDriver.WebDriver;
        }

        /// <summary>
        /// Sets up web driver base.
        /// </summary>
        protected void SetUpWebDriverBase()
        {
            // SetUpWebDriver.SetUpWebDriver.SetUpChromeWebDriver();
            SetUpWebDriver.SetUpWebDriver.SetUpFirefowWebDriver();
            this.WebDriver = SetUpWebDriver.SetUpWebDriver.WebDriver;
            this.WebDriver.Manage().Cookies.DeleteAllCookies();
            this.WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }
    }
}
