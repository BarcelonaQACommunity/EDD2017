using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PageObject.Factory.Contracts.Pages.Contracts;
using PageObject.SauceLabs.Factory.Base;

namespace PageObject.SauceLabs.Factory.Pages
{
    /// <summary>
    /// The select edit customer page.
    /// </summary>
    /// <seealso cref="SlPageObjectBase" />
    /// <seealso cref="PageObject.Factory.Contracts.Pages.Contracts.ISelectEditCustomerPage" />
    public class SLSelectEditCustomerPage : SlPageObjectBase, ISelectEditCustomerPage
    {
        #region .: Selenium WebDriver Elements .:

        /// <summary>
        /// The user identifier textbox.
        /// </summary>
        [FindsBy(How = How.Name, Using = "cusid")]
        private IWebElement _userIdTextBox;

        /// <summary>
        /// The submit button.
        /// </summary>
        [FindsBy(How = How.Name, Using = "AccSubmit")]
        private IWebElement _submitButton;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="SLSelectEditCustomerPage"/> class.
        /// </summary>
        public SLSelectEditCustomerPage()
        {
            PageFactory.InitElements(this.WebDriver, this);
        }

        /// <summary>
        /// Inserts the user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void InsertUserId(string userId)
        {
            this._userIdTextBox.SendKeys(userId);
        }

        /// <summary>
        /// Clicks the submit button.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void ClickSubmitButton()
        {
            this._submitButton.Click();
        }
    }
}
