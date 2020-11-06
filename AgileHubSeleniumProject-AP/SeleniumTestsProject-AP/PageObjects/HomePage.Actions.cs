using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTestsProject_AP.Data;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace SeleniumTestsProject_AP.PageObjects
{
    partial class HomePage : SeedData
    {
        public void VerifyElementIsDisplayed(IWebElement elementToVerify)
        {
            Assert.IsTrue(elementToVerify.Displayed);
        }

        public void GoToAutentificarCasQa()
        {
            CasQaAutentificareButton.Click();
        }

        public void GoToInscriereCasQa()
        {
            CasQaInscriereButton.Click();
        }

        public void GoToFotoPage()
        {
            CasQaFotoButton.Click();
        }

        public void GoToDeconectareButton()
        {
            CasQaDeconectareButton.Click();
        }

        public void GoToHorizontalMenu()
        {
            CasQaBusinessButton.Click();
            CasQaGamingButton.Click();
            CasQaHomeButton.Click();
            CasQaUltraportabilButton.Click();
        }

        public void GoToAdministrareMenu()
        {
            CasQaAdministrareButton.Click();
        }

        public void GoToUsersMenu()
        {
            CasQaUtilizatoriButton.Click();
        }

        public void GoogleSearchImage()
        {
            GoogleAcceptCookiesButton.Click();
            GoogleSearchBar.SendKeys(GoogleSearchCriteria);
            GoogleSearchButton.Click();
            GoogleImagesButton.Click();
            GoogleClickFirstImage.Click();
            GoogleClickFirstImage.Click();
        }

        public void UntoldHomePageMenu()
        {
            UntoldMenuButton.Click();
            UntoldHomeButton.Click();
        }

        public void TeatrulSicaAlexandrescuTeamMenu()
        {         
            TeatrulSicaAlexandrescuTeamButton.Click();
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)_driver;
            js1.ExecuteScript("window.scrollBy(0,500)", "");
            TeatrulSicaAlexandrescuFirstTeamMemberButton.Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("window.scrollBy(0,500)", "");
            Thread.Sleep(5000);
            TeatrulSicaAlexandrescuFirstShowButton.Click();
        }
    }
}
