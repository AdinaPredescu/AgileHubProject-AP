using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTestsProject_AP.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

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

        [Given(@"I login with valid user")]
        public void GivenILoginWithValidUser()
        {
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToAutentificarCasQa();
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.LoginUserCasQa("admin.test3@gmail.com", "password123");
            loginPageCasQa.VerifyElementIsDisplayed(homePageCasQa.CasQaDeconectareButton);

        }

    }
}
