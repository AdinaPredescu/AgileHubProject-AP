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
    public sealed class CasQaAddToCartSteps : Hooks1
    {
        [Given(@"I navigate to CasQa website")]
        public void GivenINavigateToCasQaWebsite()
        {
            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoSiteCasQa));
        }
        //login as regular user
        [Given(@"I login as a regular user")]
        public void GivenILoginAsARegularUser()
        {
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToAutentificarCasQa();
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.LoginUserCasQa("testname@email.com", "password1");
        }

        //login as admin
        [Given(@"I login as an admin user")]
        public void GivenILoginAsAnAdminUser()
        {
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToAutentificarCasQa();
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.LoginUserCasQa("admin.test3@gmail.com", "password123");
            homePageCasQa.GoToFotoPage();
        }

        [When(@"I add a product to the cart")]
        public void WhenIAddAProductToTheCart()
        {
            ProductPage productPageCasQa = new ProductPage(Driver);
            productPageCasQa.GoToVeziDetalii();
        }

        [Then(@"Comanda Acum button is displayed")]
        public void ThenComandaAcumButtonIsDisplayed()
        {
            ProductPage productPageCasQa = new ProductPage(Driver);
            productPageCasQa.VerifyElementIsDisplayed(productPageCasQa.CasQaComandaAcumButton);
        }
    }
}
