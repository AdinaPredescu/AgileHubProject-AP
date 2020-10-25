using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumTestsProject_AP.PageObjects
{
    partial class ProductPage
    {
        private IWebDriver _driver;

        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement CasQaVeziDetaliiButton => _driver.FindElement(By.CssSelector(".btn-primary"));
        private IWebElement CasQaAddToCartButton => _driver.FindElement(By.CssSelector(".btn-primary"));
        public IWebElement CasQaComandaAcumButton => _driver.FindElement(By.XPath("//tbody/tr[2]/th[4]/a"));
        public IWebElement CasAddNewProductButton => _driver.FindElement(By.CssSelector("a.btn.btn-primary"));
    }
}
