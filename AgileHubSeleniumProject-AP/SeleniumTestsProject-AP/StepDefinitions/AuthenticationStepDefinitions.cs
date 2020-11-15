using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTestsProject_AP.Dto;
using SeleniumTestsProject_AP.PageObjects;
using SeleniumTestsProject_AP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SeleniumTestsProject_AP.Enums;

namespace SeleniumTestsProject_AP.StepDefinitions
{
    [Binding] //specflow argument - indicates that this class is binded with a feature file
    public sealed class AuthenticationStepDefinitions : Hooks1
    {
        private readonly ScenarioContext _scenarioContext;

        public AuthenticationStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to authentication page")]
        public void GivenINavigateToAuthenticationPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAutentificarCasQa();
        }

        //[When(@"I login with user '(.*)'")]
        //public void WhenILoginWithUser(string userEmailAddress)
        //{
        //    LoginPage loginPage = new LoginPage(Driver);
        //    loginPage.EmailFieldTextBox.SendKeys(userEmailAddress);
        //}

        //[When(@"password '(.*)'")]
        //public void WhenPassword(string userPassword)
        //{
        //    LoginPage loginPage = new LoginPage(Driver);
        //    loginPage.PasswordFieldTextBox.SendKeys(userPassword);
        //    loginPage.SubmitButton.Click();
        //}

        [When(@"I login with following credentials:")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            var myUser = table.CreateInstance<UserDto>();
            LoginPage loginPage = new LoginPage(Driver);
            //loginPage.AuthenticateUser(myUser.userEmail, myUser.userPassword);
            loginPage.LoginIntoApplication(myUser);
        }

        [Then(@"I am loged in")]
        public void ThenIAmLogedIn()
        {
            HomePage homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.CasQaDeconectareButton.Displayed);
        }

        //Logout
        [Given(@"I login to CasQa website")]
        public void GivenILoginToCasQaWebsite()
        {
            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoSiteCasQa));
           
        }

        [When(@"I click Deconectare button")]
        public void WhenIClickDeconectareButton()
        {
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToAutentificarCasQa();
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.LoginUserCasQa("admin.test3@gmail.com", "password123");
            homePageCasQa.GoToDeconectareButton();           
        }

        [Then(@"Inscriere button becomes available")]
        public void ThenInscriereButtonBecomesAvailable()
        {
            HomePage homePageCasQa = new HomePage(Driver);
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.VerifyElementIsDisplayed(homePageCasQa.CasQaInscriereButton);
        }

        //Create Account and Login
        [Given(@"I navigate to CasQa sign up page")]
        public void GivenINavigateToCasQaSignUpPage()
        {
            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoSiteCasQa));
            HomePage homePageCasQa = new HomePage(Driver);           
            homePageCasQa.GoToInscriereCasQa();           
        }

        [When(@"I fill in the sign up form")]
        public void WhenIFillInTheSignUpForm()
        {
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.FillSignUpFormCasQa();
        }

        [Then(@"I can login with the newly created user")]
        public void ThenICanLoginWithTheNewlyCreatedUser()
        {
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.LoginRegularUserCasQa();
        }
    }
}
