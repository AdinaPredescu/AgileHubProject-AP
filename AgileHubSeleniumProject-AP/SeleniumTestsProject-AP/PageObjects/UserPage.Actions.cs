using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTestsProject_AP.PageObjects
{
    partial class UserPage
    {
        public void VerifyElementIsDisplayed(IWebElement elementToVerify)
        {
            Assert.IsTrue(elementToVerify.Displayed);
        }
        public void EditUserCasQa()
        {
            CasQaEditareUserButton.Click();
        }
    }
}
