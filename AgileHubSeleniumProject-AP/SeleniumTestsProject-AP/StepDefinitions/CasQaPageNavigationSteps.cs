using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SeleniumTestsProject_AP.PageObjects;
using SeleniumTestsProject_AP.Data;
using SeleniumTestsProject_AP.Enums;

namespace SeleniumTestsProject_AP.StepDefinitions
{
    [Binding]
    public sealed class CasQaPageNavigationSteps : Hooks1
    {
        [Given(@"I navigate to Casqa website")]
        public void GivenINavigateToCasqaWebsite()
        {
            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoSiteCasQa));           
        }

        [Then(@"I should be able to access all the horizontal pages")]
        public void ThenIShouldBeAbleToAccessAllTheHorizontalPages()
        {
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToHorizontalMenu();
        }

    }
}
