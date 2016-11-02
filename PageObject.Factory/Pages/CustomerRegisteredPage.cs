using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PageObject.Factory.Base;
using PageObject.Factory.Contracts.Pages.Contracts;
using PageObject.Models;

namespace PageObject.Factory.Pages
{
    /// <summary>
    /// The customer registered page.
    /// </summary>
    /// <seealso cref="PageObject.Factory.Base.PageObjectBase" />
    /// <seealso cref="PageObject.Factory.Contracts.Pages.Contracts.ICustomerRegisteredPage" />
    public class CustomerRegisteredPage : PageObjectBase, ICustomerRegisteredPage
    {
        private const string CustomerRegisteredHeader = "Customer Registered Successfully!!!";
        private const string CustomerRegisteredTitle = "Registered Customer details are as follows:";

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRegisteredPage"/> class.
        /// </summary>
        public CustomerRegisteredPage()
        {
            PageFactory.InitElements(this.WebDriver, this);
        }

        /// <summary>
        /// Determines whether [is customer registered] [the specified customer].
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns></returns>
        public bool IsCustomerRegistered(Customer customer)
        {
            return this.WebDriver.FindElements(By.TagName("p")).Any(x => x.Text.Equals(CustomerRegisteredHeader)) &&
                   this.WebDriver.FindElements(By.TagName("td")).Any(x => x.Text.Equals(CustomerRegisteredTitle)) &&
                   this.WebDriver.FindElements(By.TagName("td")).Any(x => x.Text.Equals(customer.Name)) &&
                   this.WebDriver.FindElements(By.TagName("td")).Any(x => x.Text.Equals(customer.Gender.ToLower())) &&
                   this.WebDriver.FindElements(By.TagName("td")).Any(x => x.Text.Equals(customer.Address)) &&
                   this.WebDriver.FindElements(By.TagName("td")).Any(x => x.Text.Equals(customer.City)) &&
                   this.WebDriver.FindElements(By.TagName("td")).Any(x => x.Text.Equals(customer.State)) &&
                   this.WebDriver.FindElements(By.TagName("td")).Any(x => x.Text.Equals(customer.Pin)) &&
                   this.WebDriver.FindElements(By.TagName("td")).Any(x => x.Text.Equals(customer.Telephone));
        }

        /// <summary>
        /// Swiches to alert.
        /// </summary>
        public void SwichToAlert()
        {
            var alert = this.WebDriver.SwitchTo().Alert();
            alert.Accept();
        }
    }
}
