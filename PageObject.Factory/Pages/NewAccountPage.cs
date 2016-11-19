using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using PageObject.Factory.Base;
using PageObject.Factory.Contracts.Pages.Contracts;

#pragma warning disable 649
#pragma warning disable 169

namespace PageObject.Factory.Pages
{
    /// <summary>
    /// The NewAccount page.
    /// </summary>
    /// <seealso cref="PageObject.Factory.Base.PageObjectBase" />
    /// <seealso cref="PageObject.Factory.Contracts.Pages.Contracts.INewAccountPage" />
    public class NewAccountPage : PageObjectBase, INewAccountPage
    {
        private const string CurrentAccount = "Current";
        private const string SavingsAccount = "Savings";

        #region .: Selenium WebDriver Elements :.

        /// <summary>
        /// The customer identifier text box.
        /// </summary>
        [FindsBy(How = How.Name, Using = "cusid")]
        private IWebElement _customerIdTextBox;

        /// <summary>
        /// The account type select.
        /// </summary>
        [FindsBy(How = How.Name, Using = "selaccount")]
        private IWebElement _accountTypeSelect;

        /// <summary>
        /// The initial deposit text box.
        /// </summary>
        [FindsBy(How = How.Name, Using = "inideposit")]
        private IWebElement _initialDepositTextBox;

        /// <summary>
        /// The submit button.
        /// </summary>
        [FindsBy(How = How.Name, Using = "button2")]
        private IWebElement _submitButton;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="NewAccountPage"/> class.
        /// </summary>
        public NewAccountPage()
        {
            PageFactory.InitElements(this.WebDriver, this);
        }

        /// <summary>
        /// Creates the saving account.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="initialDeposit">The initial deposit.</param>
        public void CreateSavingAccount(string customerId, int initialDeposit)
        {
            this._customerIdTextBox.SendKeys(customerId);

            // Selects current account.
            var accountSelect = new SelectElement(this._accountTypeSelect);
            accountSelect.SelectByText(SavingsAccount);

            this._initialDepositTextBox.SendKeys(initialDeposit.ToString());
        }

        /// <summary>
        /// Creates the current account.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="initialDeposit">The initial deposit.</param>
        public void CreateCurrentAccount(string customerId, int initialDeposit)
        {
            this._customerIdTextBox.SendKeys(customerId);

            // Selects savings account.
            var accountSelect = new SelectElement(this._accountTypeSelect);
            accountSelect.SelectByText(CurrentAccount);

            this._initialDepositTextBox.SendKeys(initialDeposit.ToString());
        }

        /// <summary>
        /// Clicks the submit button.
        /// </summary>
        public void ClickSubmitButton()
        {
            this._submitButton.Click();
        }
    }
}
