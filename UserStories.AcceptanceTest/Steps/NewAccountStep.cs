using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using CrossLayer.Autofac;
using PageObject.Factory.Contracts.Pages.Contracts;
using TechTalk.SpecFlow;
using UserStories.AcceptanceTest.Steps.Base;

namespace UserStories.AcceptanceTest.Steps
{
    /// <summary>
    /// The new account step.
    /// </summary>
    /// <seealso cref="UserStories.AcceptanceTest.Steps.Base.BaseStep" />
    [Binding]
    public class NewAccountStep : BaseStep
    {
        // Manager page.
        private readonly IManagerPage _managerPage;

        // New Account page.
        private readonly INewAccountPage _newAccountPage;

        /// <summary>
        /// Initializes a new instance of the <see cref="NewAccountStep"/> class.
        /// </summary>
        public NewAccountStep()
        {
            this._managerPage = AutofacContainer.SauceLabsContainer.Resolve<IManagerPage>();
            this._newAccountPage = AutofacContainer.SauceLabsContainer.Resolve<INewAccountPage>();
        }

        /// <summary>
        /// Whens the user goes to the new account page.
        /// </summary>
        [When(@"The user goes to the new account page")]
        public void WhenTheUserGoesToTheNewAccountPage()
        {
            this._managerPage.GoToNewAccountPage();
        }

        /// <summary>
        /// Whens the user creates a new account with parameters.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="accountType">Type of the account.</param>
        /// <param name="initialDeposit">The initial deposit.</param>
        [When(@"The user creates a new account with parameters '(.*)', '(.*)', '(.*)'")]
        public void WhenTheUserCreatesANewAccountWithParameters(string customerId, string accountType, int initialDeposit)
        {
            switch (accountType)
            {
                case "Current":
                    this._newAccountPage.CreateCurrentAccount(customerId, initialDeposit);
                    break;

                case "Savings":
                    this._newAccountPage.CreateSavingAccount(customerId, initialDeposit);
                    break;
            }
        }

        [When(@"The user clicks submit button to create new account")]
        public void WhenTheUserClicksSubmitButtonToCreateNewAccount()
        {
            this._newAccountPage.ClickSubmitButton();
        }
    }
}
