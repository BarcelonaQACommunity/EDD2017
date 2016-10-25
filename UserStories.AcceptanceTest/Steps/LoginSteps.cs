using Autofac;
using CrossLayer.Autofac;
using PageObject.Factory.Contracts.Pages.Contracts;
using TechTalk.SpecFlow;
using UserStories.AcceptanceTest.Steps.Base;

namespace UserStories.AcceptanceTest.Steps
{
    /// <summary>
    /// Login Steps.
    /// </summary>
    /// <seealso cref="UserStories.AcceptanceTest.Steps.Base.BaseStep" />
    [Binding]
    public class LoginSteps : BaseStep
    {
        // Home Page.
        private readonly IHomePage _homePage;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginSteps"/> class.
        /// </summary>
        public LoginSteps() : 
            base(AutofacContainer.BuildContainer)
        {
            this._homePage = this.Container.Resolve<IHomePage>();
        }

        /// <summary>
        /// Givens the user enters to the home page.
        /// </summary>
        [Given(@"The user enters to the home page")]
        public void GivenTheUserEntersToTheHomePage()
        {
            this._homePage.GoToHomePage();
        }

        /// <summary>
        /// Whens the user logs with a valid user.
        /// </summary>
        [When(@"The user logs with a valid user")]
        public void WhenTheUserLogsWithAValidUser()
        {
            this._homePage.LoginUser("asfd", "qwer");
        }

        /// <summary>
        /// Thens the user has logged correctly.
        /// </summary>
        [Then(@"The user has logged correctly")]
        public void ThenTheUserHasLoggedCorrectly()
        {
            // TODO
        }
    }
}
