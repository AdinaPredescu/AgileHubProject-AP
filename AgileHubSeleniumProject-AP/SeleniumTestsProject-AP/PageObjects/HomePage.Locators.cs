using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestsProject_AP.PageObjects
{
    partial class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        //DemositeCasqadLocators
        #region
        private IWebElement CasQaAutentificareButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        public IWebElement CasQaInscriereButton => _driver.FindElement(By.XPath("//a[text()='Înscriere']"));
        public IWebElement CasQaDeconectareButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));
        private IWebElement CasQaFotoButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[3]/a"));
        private IWebElement CasQaBusinessButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/div/a[2]"));
        private IWebElement CasQaGamingButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/div/a[3]"));
        private IWebElement CasQaHomeButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/div/a[4]"));
        private IWebElement CasQaUltraportabilButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/div/a[5]"));
        private IWebElement CasQaAdministrareButton => _driver.FindElement(By.XPath("//a[text()='Administrare']"));
        private IWebElement CasQaUtilizatoriButton => _driver.FindElement(By.XPath("//a[text()='Utilizatori']"));
        #endregion

        //GoogleLocators
        #region
        private IWebElement GoogleAcceptCookiesButton => _driver.FindElement(By.XPath("//*[@id='introAgreeButton']/span[@class='CwaK9']/span[@class='RveJvd snByac']"));
        private IWebElement GoogleSearchBar => _driver.FindElement(By.CssSelector("input[name=q]"));
        private IWebElement GoogleSearchButton => _driver.FindElement(By.CssSelector("input[name=btnK]"));
        private IWebElement GoogleImagesButton => _driver.FindElement(By.CssSelector("#hdtb-msb-vis > div:nth-child(2) > a"));
        private IWebElement GoogleClickFirstImage => _driver.FindElement(By.CssSelector("#islrg > div.islrc > div:nth-child(1) > a.wXeWr.islib.nfEiy.mM5pbd"));
        public IWebElement GoogleAllButton => _driver.FindElement(By.XPath("//*[@id='yDmH0d']/div[2]/c-wiz/div[1]/div/div[1]/div[1]/div/div/a[1]"));
        #endregion

        //UntoldLocators
        #region
        public IWebElement UntoldMenuButton => _driver.FindElement(By.XPath("//div[@class='bm-burger-button']"));
        private IWebElement UntoldHomeButton => _driver.FindElement(By.XPath("//*[@id='untold-container']/header/div[2]/div[2]/div[1]/nav/div[1]/a[1]/span"));
        #endregion

        //TeatrulSicaAlexandrescuLocators
        #region
        private IWebElement TeatrulSicaAlexandrescuTeamButton => _driver.FindElement(By.CssSelector("#menu-item-2914 > a"));
        private IWebElement TeatrulSicaAlexandrescuFirstTeamMemberButton => _driver.FindElement(By.CssSelector("#av-masonry-1-item-2697 > figure > div > div"));
        private IWebElement TeatrulSicaAlexandrescuFirstShowButton => _driver.FindElement(By.XPath("//*[@id='av-layout-grid-1']/div[1]/div/div[1]/section/div/p[2]/a"));
        public IWebElement BuyTicketButton => _driver.FindElement(By.XPath("//*[@id='av-layout-grid-1']/div[1]/div/div[1]/a/span"));
        #endregion
    }
}
