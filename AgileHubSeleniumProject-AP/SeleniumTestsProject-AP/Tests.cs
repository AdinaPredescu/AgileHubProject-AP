using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SeleniumTestsProject_AP.PageObjects;
using SeleniumTestsProject_AP.Data;
using SeleniumTestsProject_AP.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestsProject_AP
{
    [TestFixture, Category("Login")]
    class Tests : Hooks1
    {

        [Test, Category("Login")]
        public void ValidateLoginIntoApplicationWithValidCredentials()
        {
            // Arrange
            HomePage homePage = new HomePage(Driver);
            // Act
            homePage.GoToAutentificarCasQa();
            LoginPage loginPage = new LoginPage(Driver);
            // Assert
            loginPage.VerifyElementIsDisplayed(homePage.CasQaDeconectareButton);

            Thread.Sleep(2000);
        }

        [Test]
        public void NavigateToGoogleImages()
        {
            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.GoogleHomePage));
            HomePage googleHomePage = new HomePage(Driver);
            Driver.SwitchTo().Frame(Driver.FindElement(By.CssSelector("#cnsw > iframe")));
            googleHomePage.GoogleSearchImage();
            googleHomePage.VerifyElementIsDisplayed(googleHomePage.GoogleAllButton);

            Thread.Sleep(2000);
        }

        [Test]
        public void NavigateToUntoldHomePage()
        {
            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.Untold));
            HomePage untoldHomePage = new HomePage(Driver);
            untoldHomePage.UntoldHomePageMenu();
            untoldHomePage.VerifyElementIsDisplayed(untoldHomePage.UntoldMenuButton);

            Thread.Sleep(2000);
        }

        [Test]
        //WIP
        public void ValidateRegistrationFormSubmitDemoQa()
        {

            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoQaAutomationForm));
            LoginPage loginPageDemoQa = new LoginPage(Driver);
            loginPageDemoQa.RegisterStudentFormDemoQa();
            Thread.Sleep(2000);
        }

        [Test]
        public void ValidateTextboxFormDemoQa()
        {

            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoQaTextBox));
            LoginPage loginPageDemoQa = new LoginPage(Driver);
            loginPageDemoQa.TextBoxFormDemoQa();
            loginPageDemoQa.VerifyElementIsDisplayed(loginPageDemoQa.DemoQaOutputInfo);
            Thread.Sleep(2000);
        }

        [Test]
        public void NavigateToFirstShowOfFirstTeamMember()
        {

            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.TeatrulSicaAlexandrescu));
            HomePage homePageTeatrulSicaAlexandrescu = new HomePage(Driver);
            homePageTeatrulSicaAlexandrescu.TeatrulSicaAlexandrescuTeamMenu();
            Thread.Sleep(2000);
        }

        [Test]
        //WIP - login issues
        public void ValidateSignUpAndLoginCasQa()
        {

            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoSiteCasQa));
            HomePage homePageCasQa = new HomePage(Driver);
            LoginPage loginPageCasQa = new LoginPage(Driver);
            homePageCasQa.GoToInscriereCasQa();
            loginPageCasQa.FillSignUpFormCasQa();
            loginPageCasQa.LoginRegularUserCasQa();
            Thread.Sleep(5000);
        }

        [Test]
        public void ValidateLoginCasQa()
        {

            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoSiteCasQa));
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToAutentificarCasQa();
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.LoginUserCasQa("admin.test3@gmail.com", "password123");
            loginPageCasQa.VerifyElementIsDisplayed(homePageCasQa.CasQaDeconectareButton);

            Thread.Sleep(5000);
        }

        [Test]
        public void ValidateAddProductToCartAsRegularUserCasQa()
        {

            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoSiteCasQa));
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToAutentificarCasQa();
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.LoginUserCasQa("testname@email.com", "password1");
            ProductPage productPageCasQa = new ProductPage(Driver);
            productPageCasQa.GoToVeziDetalii();
            productPageCasQa.VerifyElementIsDisplayed(productPageCasQa.CasQaComandaAcumButton);

            Thread.Sleep(5000);
        }

        [Test]
        public void ValidateAddProductToCartAsAdminUserCasQa()
        {

            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoSiteCasQa));
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToAutentificarCasQa();
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.LoginUserCasQa("admin.test3@gmail.com", "password123");
            homePageCasQa.GoToFotoPage();
            ProductPage productPageCasQa = new ProductPage(Driver);
            productPageCasQa.GoToVeziDetalii();
            productPageCasQa.VerifyElementIsDisplayed(productPageCasQa.CasQaComandaAcumButton);

            Thread.Sleep(2000);
        }

        [Test]
        public void ValidateLogoutCasQa()
        {

            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoSiteCasQa));
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToAutentificarCasQa();
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.LoginUserCasQa("admin.test3@gmail.com", "password123");
            homePageCasQa.GoToDeconectareButton();
            loginPageCasQa.VerifyElementIsDisplayed(homePageCasQa.CasQaInscriereButton);

            Thread.Sleep(5000);
        }

        [Test]
        public void CheckAllHorizontalMenusCasQa()
        {

            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoSiteCasQa));
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToHorizontalMenu();

            Thread.Sleep(5000);
        }

        [Test]
        public void CheckAdministrareMenuCasQa()
        {

            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoSiteCasQa));
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToAutentificarCasQa();
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.LoginUserCasQa("admin.test3@gmail.com", "password123");
            homePageCasQa.GoToAdministrareMenu();
            ProductPage productPageCasQa = new ProductPage(Driver);
            productPageCasQa.VerifyElementIsDisplayed(productPageCasQa.CasAddNewProductButton);

            Thread.Sleep(5000);
        }

        [Test]
        public void CheckUsersMenuCasQa()
        {

            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoSiteCasQa));
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToAutentificarCasQa();
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.LoginUserCasQa("admin.test3@gmail.com", "password123");
            homePageCasQa.GoToAdministrareMenu();
            homePageCasQa.GoToUsersMenu();
            UserPage userPageCasQa = new UserPage(Driver);
            userPageCasQa.VerifyElementIsDisplayed(userPageCasQa.CasQaComenziHeader);

            Thread.Sleep(5000);
        }

        [Test]
        public void CheckEditUserCasQa()
        {

            Driver.Navigate().GoToUrl(TestEnvData.GetBaseUrl(TestEnvironments.DemoSiteCasQa));
            HomePage homePageCasQa = new HomePage(Driver);
            homePageCasQa.GoToAutentificarCasQa();
            LoginPage loginPageCasQa = new LoginPage(Driver);
            loginPageCasQa.LoginUserCasQa("admin.test3@gmail.com", "password123");
            homePageCasQa.GoToAdministrareMenu();
            homePageCasQa.GoToUsersMenu();
            UserPage userPageCasQa = new UserPage(Driver);
            userPageCasQa.EditUserCasQa();
            userPageCasQa.VerifyElementIsDisplayed(userPageCasQa.CasQaUpdateUserButton);

            Thread.Sleep(5000);
        }
    }
}
