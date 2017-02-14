using System;
using System.Drawing.Imaging;
using System.Globalization;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

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
        /// Sets up sauce labs web driver.
        /// </summary>
        public static void SetUpSauceLabsWebDriver()
        {
            var caps = new DesiredCapabilities();
            caps.SetCapability(CapabilityType.BrowserName, "chrome");
            caps.SetCapability(CapabilityType.Version, "45");
            caps.SetCapability(CapabilityType.Platform, "Windows 10");
            caps.SetCapability("deviceName", "");
            caps.SetCapability("deviceOrientation", "");
            caps.SetCapability("username", "nyoronsheppard");
            caps.SetCapability("accessKey", "ba81bd05-eb98-4a41-a837-65817ccc8bc1");

            WebDriver = new RemoteWebDriver(new Uri("http://ondemand.saucelabs.com:80/wd/hub"), caps, TimeSpan.FromSeconds(600));
        }

        /// <summary>
        /// Makes the screenshot.
        /// </summary>
        /// <param name="scenario">The scenario.</param>
        public static void MakeScreenshot(string scenario)
        {
            var screenshot = ((ITakesScreenshot)WebDriver).GetScreenshot();
            var asdf = $"{DateTime.Now.ToString("d-M-yyyy HH-mm-ss", CultureInfo.InvariantCulture)}_{scenario}.jpeg";
            screenshot.SaveAsFile(asdf, ImageFormat.Jpeg);
        }


        /// <summary>
        /// Closes the chrome web driver.
        /// </summary>
        public static void CloseChromeWebDriver()
        {
            WebDriver?.Dispose();
        }
    }
}
