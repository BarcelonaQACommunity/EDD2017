using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageObject.Factory.Base
{
    /// <summary>
    /// The Page Object base.
    /// </summary>
    public class PageObjectBase
    {
        protected IWebDriver WebDriver;

        public PageObjectBase(IWebDriver webDriver)
        {
            this.WebDriver = webDriver;
        }
    }
}
