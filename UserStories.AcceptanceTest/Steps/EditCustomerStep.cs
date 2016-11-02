using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using CrossLayer.Autofac;
using PageObject.Factory.Contracts.Pages.Contracts;
using TechTalk.SpecFlow;
using UserStories.AcceptanceTest.Steps.Base;

namespace UserStories.AcceptanceTest.Steps
{
    /// <summary>
    /// The edit customer steps.
    /// </summary>
    /// <seealso cref="UserStories.AcceptanceTest.Steps.Base.BaseStep" />
    [Binding]
    public class EditCustomerStep : BaseStep
    {
        // Manager page.
        private readonly IManagerPage _managerPage;

        // Select edit customer page.
        private readonly ISelectEditCustomerPage _selectEditCustomerPage;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCustomerStep"/> class.
        /// </summary>
        public EditCustomerStep()
        {
            this._managerPage = AutofacContainer.AContainer.Resolve<IManagerPage>();
            this._selectEditCustomerPage = AutofacContainer.AContainer.Resolve<ISelectEditCustomerPage>();
        }

        [When(@"The user goes to the select edit customer page")]
        public void WhenTheUserGoesToTheSelectEditCustomerPage()
        {
            this._managerPage.GoToEditCustomerPage();
        }

        [When(@"The user inserts a valid customer id")]
        public void WhenTheUserInsertsAValidCustomerId()
        {
            this._selectEditCustomerPage.InsertUserId("56274");
        }

        [When(@"The user clicks the select edit customer submit button")]
        public void WhenTheUserClicksTheSubmitButton()
        {
            this._selectEditCustomerPage.ClickSubmitButton();
        }
    }
}
