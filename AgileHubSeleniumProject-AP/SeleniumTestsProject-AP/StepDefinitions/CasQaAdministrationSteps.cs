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
    [Binding]
    public sealed class CasQaAdministrationSteps : Hooks1
    {
        [Given(@"I am logged in as an admin user")]
        public void GivenIAmLoggedInAsAnAdminUser()
        {
            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoSiteCasQa));
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToAutentificarCasQa();
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.LoginUserCasQa("admin.test3@gmail.com", "password123");
            Thread.Sleep(3000);

        }

        [When(@"I navigate to Administration page")]
        public void WhenINavigateToAdministrationPage()
        {
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToAdministrareMenu();
        }

        [Then(@"I should see the menu")]
        public void ThenIShouldSeeTheMenu()
        {
            ProductPage productPageCasQa = new ProductPage(Driver);
            productPageCasQa.VerifyElementIsDisplayed(productPageCasQa.CasAddNewProductButton);
        }

        [When(@"I click on the Users menu")]
        public void WhenIClickOnTheUsersMenu()
        {
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToUsersMenu();
        }

        [Then(@"I should see a list of users")]
        public void ThenIShouldSeeAListOfUsers()
        {
            UserPage userPageCasQa = new UserPage(Driver);
            userPageCasQa.VerifyElementIsDisplayed(userPageCasQa.CasQaComenziHeader);
        }

        [When(@"I click on the Edit user button")]
        public void WhenIClickOnTheEditUserButton()
        {
            UserPage userPageCasQa = new UserPage(Driver);
            userPageCasQa.EditUserCasQa();           
        }

        [Then(@"I should be able to edit the user page")]
        public void ThenIShouldBeAbleToEditTheUserPage()
        {
            UserPage userPageCasQa = new UserPage(Driver);
            userPageCasQa.VerifyElementIsDisplayed(userPageCasQa.CasQaUpdateUserButton);
        }

    }
}
