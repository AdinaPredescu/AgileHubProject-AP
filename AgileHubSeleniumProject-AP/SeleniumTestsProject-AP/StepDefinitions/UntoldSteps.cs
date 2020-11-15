using TechTalk.SpecFlow;
using SeleniumTestsProject_AP.PageObjects;
using SeleniumTestsProject_AP.Data;
using SeleniumTestsProject_AP.Enums;

namespace SeleniumTestsProject_AP.StepDefinitions
{
    [Binding]
    public sealed class UntoldSteps : Hooks1
    {

        [Given(@"I navigate to Untold website")]
        public void GivenINavigateToUntoldWebsite()
        {
            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.Untold));
        }


        [When(@"I click on the navigation menu from the top right hand corner")]
        public void WhenIClickOnTheNavigationMenuFromTheTopRightHandCorner()
        {
            HomePage untoldHomePage = new HomePage(Driver);
            untoldHomePage.UntoldHomePageMenu();
        }

        [Then(@"I should see Home option")]
        public void ThenIShouldSeeHomeOption()
        {
            HomePage untoldHomePage = new HomePage(Driver);
            untoldHomePage.VerifyElementIsDisplayed(untoldHomePage.UntoldMenuButton);
        }

    }
}
