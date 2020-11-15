using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SeleniumTestsProject_AP.PageObjects;
using SeleniumTestsProject_AP.Data;
using SeleniumTestsProject_AP.Enums;
using System.Threading;

namespace SeleniumTestsProject_AP.StepDefinitions
{
    //WIP
    [Binding]
    public sealed class DemoQaSteps : Hooks1
    {
        [Given(@"I navigate to DemoQa website")]
        public void GivenINavigateToDemoQaWebsite()
        {
            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoQaAutomationForm));

        }

        [When(@"I fill in the registration form")]
        public void WhenIFillInTheRegistrationForm()
        {
            LoginPage loginPageDemoQa = new LoginPage(Driver);
            loginPageDemoQa.RegisterStudentFormDemoQa();
            Thread.Sleep(2000);
        }

        [Then(@"my account should be submitted")]
        public void ThenMyAccountShouldBeSubmitted()
        {
            LoginPage loginPageDemoQa = new LoginPage(Driver);
            loginPageDemoQa.VerifyElementIsDisplayed(loginPageDemoQa.DemoQaOutputInfo);
        }

        //---------------------------------------

        [Given(@"I navigate to DemoQa textbox information website page")]
        public void GivenINavigateToDemoQaTextboxInformationWebsitePage()
        {
            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoQaTextBox));
        }

        [When(@"I fill in all the required fields")]
        public void WhenIFillInAllTheRequiredFields()
        {
            LoginPage loginPageDemoQa = new LoginPage(Driver);
            loginPageDemoQa.TextBoxFormDemoQa();
        }

        [Then(@"my entered information should be submitted")]
        public void ThenMyEnteredInformationShouldBeSubmitted()
        {
            LoginPage loginPageDemoQa = new LoginPage(Driver);
            loginPageDemoQa.VerifyElementIsDisplayed(loginPageDemoQa.DemoQaOutputInfo);
            Thread.Sleep(2000);
        }


    }
}
