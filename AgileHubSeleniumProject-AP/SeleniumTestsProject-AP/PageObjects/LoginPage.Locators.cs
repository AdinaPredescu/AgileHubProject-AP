using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace SeleniumTestsProject_AP.PageObjects
{
   
    partial class LoginPage
    {
        //CasQaLocators
        #region
        private IWebElement CasQaEmailFieldTextBox => _driver.FindElement(By.CssSelector("input[type=email]"));
        private IWebElement CasQaPasswordFieldTextBox => _driver.FindElement(By.CssSelector("input[type=password]"));
        private IWebElement CasQaSubmitButton => _driver.FindElement(By.CssSelector("button[type=submit]"));
        private IWebElement CasQaFullNameTextBox => _driver.FindElement(By.CssSelector("input[placeholder='Adaugă numele complet']"));
        private IWebElement CasQaPhoneNumberTextBox => _driver.FindElement(By.CssSelector("input[name=phone]"));
        private IWebElement CasQaAddressTextBox => _driver.FindElement(By.CssSelector("textarea[name=address]"));
        private IWebElement CasQaPasswordTextBox => _driver.FindElement(By.CssSelector("input[name=password_1]"));
        private IWebElement CasQaPasswordRepeatTextBox => _driver.FindElement(By.CssSelector("input[name=password_2]"));
        #endregion

        //DemoQA Locators
        #region
        private IWebElement DemoQaFirstName => _driver.FindElement(By.CssSelector("#firstName"));
        private IWebElement DemoQaLastName => _driver.FindElement(By.CssSelector("#lastName"));
        private IWebElement DemoQaUserEmail => _driver.FindElement(By.CssSelector("#userEmail"));
        private IWebElement DemoQaUserGender => _driver.FindElement(By.CssSelector("#gender-radio-2"));
        private IWebElement DemoQaUserPhoneNumber => _driver.FindElement(By.CssSelector("#userNumber"));
        private IWebElement DemoQaUserBirthDatePicker => _driver.FindElement(By.CssSelector("#dateOfBirthInput"));
        private IWebElement DemoQaUserBirthDateMonth => _driver.FindElement(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/select/option[1]"));
        private IWebElement DemoQaUserBirthDateYear => _driver.FindElement(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[2]/select/option[101]"));
        private IWebElement DemoQaUserBirthDateDay => _driver.FindElement(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[2]/div[1]/div[7]"));
        private IWebElement DemoQaSubjects => _driver.FindElement(By.XPath("//*[@id='subjectsContainer']/div/div[1]"));
        private IWebElement DemoQaHobbies => _driver.FindElement(By.CssSelector("#hobbies-checkbox-1"));
        private IWebElement DemoQaCurrentAddress => _driver.FindElement(By.CssSelector("#currentAddress"));
        private IWebElement DemoQaState => _driver.FindElement(By.CssSelector("#state > div"));
        private IWebElement DemoQaCity => _driver.FindElement(By.CssSelector("#city > div"));
        private IWebElement DemoQaSubmitButton => _driver.FindElement(By.CssSelector("#submit"));
        private IWebElement DemoQaTextboxFullName => _driver.FindElement(By.CssSelector("#userName"));
        private IWebElement DemoQaTextboxPermanentAddress => _driver.FindElement(By.CssSelector("#permanentAddress"));
        public IWebElement DemoQaOutputInfo => _driver.FindElement(By.CssSelector("#output > div"));
        #endregion
    }
}
