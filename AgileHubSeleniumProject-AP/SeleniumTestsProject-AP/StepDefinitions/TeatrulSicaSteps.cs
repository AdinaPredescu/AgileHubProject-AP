using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SeleniumTestsProject_AP.PageObjects;
using SeleniumTestsProject_AP.Data;
using SeleniumTestsProject_AP.Enums;
using System.Threading;
using NUnit.Framework;

namespace SeleniumTestsProject_AP.StepDefinitions
{
    //WIP assert
    [Binding]
    public sealed class TeatrulSicaSteps : Hooks1
    {
        [Given(@"I navigate to Teatrul Sica Alexandrescu website")]
        public void GivenINavigateToTeatrulSicaAlexandrescuWebsite()
        {
            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.TeatrulSicaAlexandrescu));
        }

        [When(@"I navigate to the first actor page")]
        public void WhenINavigateToTheFirstActorPage()
        {
            HomePage homePageTeatrulSicaAlexandrescu = new HomePage(Driver);
            homePageTeatrulSicaAlexandrescu.TeatrulSicaAlexandrescuTeamMenu();

        }

        [When(@"I select the first displayed show")]
        public void WhenISelectTheFirstDisplayedShow()
        {
            HomePage homePageTeatrulSicaAlexandrescu = new HomePage(Driver);
            homePageTeatrulSicaAlexandrescu.TeatrulSicaAlexandrescuTeamMenuFirstShow();
            Thread.Sleep(2000);
        }

        [Then(@"I should see information about the show")]
        public void ThenIShouldSeeInformationAboutTheShow()
        {
            HomePage homePageTeatrulSicaAlexandrescu = new HomePage(Driver);
            homePageTeatrulSicaAlexandrescu.VerifyElementIsDisplayed(homePageTeatrulSicaAlexandrescu.BuyTicketButton);
        }

    }
}
