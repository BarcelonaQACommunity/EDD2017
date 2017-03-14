using PageObject.Factory.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PageObject.Factory.Contracts.Pages.Contracts;
using PageObject.Models;

#pragma warning disable 649
#pragma warning disable 169

namespace PageObject.Factory.Pages
{
    /// <summary>
    /// The Edit customer page.
    /// </summary>
    /// <seealso cref="PageObject.Factory.Base.PageObjectBase" />
    /// <seealso cref="PageObject.Factory.Contracts.Pages.Contracts.IEditCustomerPage" />
    public class EditCustomerPage : PageObjectBase, IEditCustomerPage
    {
        #region .: Selenium WebDriver Elements :.

        //TO DO

        // Address text box.
        [FindsBy(How = How.Name, Using = "addr")]
        private IWebElement _addressTextBox;
        
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCustomerPage"/> class.
        /// </summary>
        public EditCustomerPage()
        {
            PageFactory.InitElements(this.WebDriver, this);
        }

        /// <summary>
        /// Edits the customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public void EditCustomer(Customer customer)
        {
            //TO DO
        }
    }
}
