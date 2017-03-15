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
            this._managerPage = AutofacContainer.AContainer.Resolve<IManagerPage>();
            this._newAccountPage = AutofacContainer.AContainer.Resolve<INewAccountPage>();
        }

        //TO DO Exercise 2

    }
}
