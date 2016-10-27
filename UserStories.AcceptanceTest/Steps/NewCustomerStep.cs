using Autofac;
using CrossLayer.Autofac;
using PageObject.Factory.Contracts.Pages.Contracts;
using PageObject.Models;
using TechTalk.SpecFlow;
using UserStories.AcceptanceTest.Steps.Base;

namespace UserStories.AcceptanceTest.Steps
{
    /// <summary>
    /// The new customer step.
    /// </summary>
    /// <seealso cref="UserStories.AcceptanceTest.Steps.Base.BaseStep" />
    [Binding]
    public class NewCustomerStep : BaseStep
    {
        // Manager page.
        private readonly IManagerPage _managerPage;

        // New customer page.
        private readonly INewCustomerPage _newCustomerPage;

        public NewCustomerStep()
        {
            this._managerPage = AutofacContainer.AContainer.Resolve<IManagerPage>();
            this._newCustomerPage = AutofacContainer.AContainer.Resolve<INewCustomerPage>();
        }

        [When(@"The user goes to the new customer page")]
        public void WhenTheUserGoesToTheNewCustomerPage()
        {
            this._managerPage.GoToAddNewCustomerPage();
        }

        [When(@"The user creates a new customer with parameters '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)'")]
        public void WhenTheUserCreatesANewCustomerWithParameters(string name, string date, string gender, string address,
            string city, string state, string pin, string telephone, string email, string password)
        {
            var customer = new Customer
            {
                Name = name,
                Date = date,
                Gender = gender,
                Address = address,
                City = city,
                State = state,
                Pin = pin,
                Telephone = telephone,
                Email = email,
                Password = password
            };

            this._newCustomerPage.AddNewCustomer(customer);
        }
    }
}
