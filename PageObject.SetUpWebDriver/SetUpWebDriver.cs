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
        /// Sets up fire fox web driver.
        /// </summary>
        /// <returns><see cref="IWebDriver"/></returns>
        public static IWebDriver SetUpChromeWebDriver()
        {
            return new ChromeDriver(ChromeDriverService.CreateDefaultService(ChromePath), new ChromeOptions(), TimeSpan.FromSeconds(10));
        }
    }
}
