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
using PageObject.Models;

namespace UserStories.AcceptanceTest.Steps
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        // Edit Customer page.
        private readonly IEditCustomerPage _editCustomerPage;

        // Customer updated page.
        private readonly ICustomerRegisteredPage _customerRegisteredPage;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditCustomerStep"/> class.
        /// </summary>
        public EditCustomerStep()
        {
            this._managerPage = AutofacContainer.AContainer.Resolve<IManagerPage>();
            this._selectEditCustomerPage = AutofacContainer.AContainer.Resolve<ISelectEditCustomerPage>();
            this._editCustomerPage = AutofacContainer.AContainer.Resolve<IEditCustomerPage>();
            this._customerRegisteredPage = AutofacContainer.AContainer.Resolve<ICustomerRegisteredPage>();
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

        /// <summary>
        /// Whens the user creates a new customer with parameters.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="pin">The pin.</param>
        /// <param name="telephone">The telephone.</param>
        /// <param name="password">The password.</param>
        [When(@"The user edit a customer with parameters '(.*)', '(.*)', '(.*)', '(.*)', '(.*)'")]
        public void WhenTheUserCreatesANewCustomerWithParameters(string address, string city, string state, string pin, string telephone)
        {
            var random = new Random();

            var customer = new Customer
            {
                Address = address.Replace("empty", ""),
                City = city.Replace("empty", ""),
                State = state.Replace("empty", ""),
                Pin = pin.Replace("empty", ""),
                Telephone = telephone.Replace("empty", ""),
                Email = string.Concat(random.Next(), "@", random.Next(), ".com"),
            };

            this._editCustomerPage.EditCustomer(customer);
        }

        /// <summary>
        /// Thens the customer with parameters has been edited.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="date">The date.</param>
        /// <param name="gender">The gender.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="pin">The pin.</param>
        /// <param name="telephone">The telephone.</param>
        [Then(@"The customer with parameters '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)' has been edited")]
        public void ThenTheCustomerWithParametersHasBeenEdited(string name, string date, string gender, string address,
            string city, string state, string pin, string telephone)
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
            };

            Assert.IsTrue(this._customerRegisteredPage.IsCustomerUpdated(customer));
        }
    }
}
