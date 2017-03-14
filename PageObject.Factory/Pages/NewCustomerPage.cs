using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PageObject.Factory.Base;
using PageObject.Factory.Contracts.Pages.Contracts;
using PageObject.Models;

#pragma warning disable 649
#pragma warning disable 169

namespace PageObject.Factory.Pages
{
    /// <summary>
    /// The NewCustomer page.
    /// </summary>
    /// <seealso cref="PageObject.Factory.Base.PageObjectBase" />
    /// <seealso cref="PageObject.Factory.Contracts.Pages.Contracts.INewCustomerPage" />
    public class NewCustomerPage : PageObjectBase, INewCustomerPage
    {
        private const string Male = "Male";
        private const string Female = "Female";

        #region .: Selenium WebDriver Elements :.
        
        //TO DO

        // Name text box.
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement _nameTextBox;


        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="NewCustomerPage"/> class.
        /// </summary>
        public NewCustomerPage()
        {
            PageFactory.InitElements(this.WebDriver, this);
        }

        /// <summary>
        /// Adds the new customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <exception cref="System.Exception">Customer gender only can be set to Male or Female</exception>
        public void AddNewCustomer(Customer customer)
        {
            //TO DO
        }

        /// <summary>
        /// Clicks the submit button.
        /// </summary>
        public void ClickSubmitButton()
        {
            //TO DO
        }

        /// <summary>
        /// Clicks the reset button.
        /// </summary>
        public void ClickResetButton()
        {
            //TO DO
        }
    }
}
