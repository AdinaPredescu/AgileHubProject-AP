using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumTestsProject_AP.PageObjects
{
    partial class UserPage
    {
        private IWebDriver _driver;

        public UserPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement CasQaEditareUserButton => _driver.FindElement(By.XPath("//tr[1]/td[8]/a[1]"));
        public IWebElement CasQaComenziHeader => _driver.FindElement(By.XPath("//tr/th[7]"));
        public IWebElement CasQaUpdateUserButton => _driver.FindElement(By.CssSelector("button[type=submit]"));

    }
}
