﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTestsProject_AP.PageObjects
{
    partial class ProductPage
    {
        public void VerifyElementIsDisplayed(IWebElement elementToVerify)
        {
            Assert.IsTrue(elementToVerify.Displayed);
        }
        public void GoToVeziDetalii()
        {
            CasQaVeziDetaliiButton.Click();
            CasQaAddToCartButton.Click();
        }
    }
}
