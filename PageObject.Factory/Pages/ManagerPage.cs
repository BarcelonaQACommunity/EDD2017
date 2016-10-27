using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PageObject.Factory.Base;
using PageObject.Factory.Contracts.Pages.Contracts;

#pragma warning disable 649
#pragma warning disable 169

namespace PageObject.Factory.Pages
{
    public class ManagerPage : PageObjectBase, IManagerPage
    {
        #region .: Selenium WebDriver Elements :.
        
        // The user welcome Text Box.
        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Manger Id :')]")]
        private IWebElement _userWelcomeTextBox;

        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'New Customer')]")]
        private IWebElement _newCustomerButton;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerPage"/> class.
        /// </summary>
        public ManagerPage()
        {
            PageFactory.InitElements(this.WebDriver, this);
        }

        /// <summary>
        /// Gets the user manager welcome.
        /// </summary>
        /// <returns></returns>
        public string GetWelcomeUserManager()
        {
            return this._userWelcomeTextBox.Text;
        }

        /// <summary>
        /// Goes to add new customer page.
        /// </summary>
        public void GoToAddNewCustomerPage()
        {
            this._newCustomerButton.Click();
        }
    }
}
