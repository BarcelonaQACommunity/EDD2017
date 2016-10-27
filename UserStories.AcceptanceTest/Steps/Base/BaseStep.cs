using PageObject.SetUpWebDriver;
using TechTalk.SpecFlow;

namespace UserStories.AcceptanceTest.Steps.Base
{
    /// <summary>
    /// The base step.
    /// </summary>
    public class BaseStep
    {
        [AfterScenario()]
        public void AfterScenario()
        {
            SetUpWebDriver.CloseChromeWebDriver();
        }
    }
}
