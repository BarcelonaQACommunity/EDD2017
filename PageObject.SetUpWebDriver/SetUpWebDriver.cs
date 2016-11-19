using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObject.SetUpWebDriver
{
    /// <summary>
    /// Selenium Web Driver set up Class
    /// </summary>
    public static class SetUpWebDriver
    {
        private const string ChromePath = @"D:\";

        /// <summary>
        /// Gets the web driver.
        /// </summary>
        /// <value>
        /// The web driver.
        /// </value>
        public static IWebDriver WebDriver { get; private set; }

        /// <summary>
        /// Sets up fire fox web driver.
        /// </summary>
        /// <returns><see cref="IWebDriver"/></returns>
        public static void SetUpChromeWebDriver()
        {
            WebDriver = new ChromeDriver(ChromeDriverService.CreateDefaultService(ChromePath), new ChromeOptions(), TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// Closes the chrome web driver.
        /// </summary>
        public static void CloseChromeWebDriver()
        {
            if (WebDriver != null)
            {
                WebDriver.Dispose();
            }
        }
    }
}
