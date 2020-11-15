using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SeleniumTestsProject_AP.PageObjects;
using SeleniumTestsProject_AP.Data;
using SeleniumTestsProject_AP.Enums;
using OpenQA.Selenium;

namespace SeleniumTestsProject_AP.StepDefinitions
{
    [Binding]
    public sealed class GoogleSearchSteps : Hooks1
    {
        [Given(@"I navigate to Google homepage")]
        public void GivenINavigateToGoogleHomepage()
        {
            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.GoogleHomePage));           
            Driver.SwitchTo().Frame(Driver.FindElement(By.CssSelector("#cnsw > iframe")));
        }

        [Given(@"I search for Paris")]
        public void GivenISearchForParis()
        {
            HomePage googleHomePage = new HomePage(Driver);
            googleHomePage.GoogleSearchParis();                                  
        }

        [When(@"I click on the first resulted image")]
        public void WhenIClickOnTheFirstResultedImage()
        {
            HomePage googleHomePage = new HomePage(Driver);
            googleHomePage.GoogleSearchImage();
        }

        [Then(@"I should view the picture")]
        public void ThenIShouldViewThePicture()
        {
            HomePage googleHomePage = new HomePage(Driver);
            googleHomePage.GoogleSearchClickImage();
        }

        [Then(@"return to the results page")]
        public void ThenReturnToTheResultsPage()
        {
            HomePage googleHomePage = new HomePage(Driver);
            googleHomePage.GoogleSearchImageBack();
            googleHomePage.VerifyElementIsDisplayed(googleHomePage.GoogleAllButton);
        }

    }
}
