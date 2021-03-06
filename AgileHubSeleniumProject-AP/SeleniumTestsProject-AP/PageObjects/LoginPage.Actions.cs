﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumTestsProject_AP.Data;
using System.Threading;
using SeleniumTestsProject_AP.Dto;
using System.Reflection;

namespace SeleniumTestsProject_AP.PageObjects
{
    partial class LoginPage : SeedData
    {
        private IWebDriver _driver;
       private WebDriverWait _driverWait;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
           _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
           _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        public void VerifyElementIsDisplayed(IWebElement elementToVerify)
        {
           Assert.IsTrue(elementToVerify.Displayed); 
        }

        //DemoQA Registration Form Actions
        public void RegisterStudentFormDemoQa()
        {
            DemoQaFirstName.SendKeys(UserFirstName);
            DemoQaLastName.SendKeys(UserLastName);
            DemoQaUserEmail.SendKeys(UserEmail);
            DemoQaUserGender.SendKeys(Keys.Space);
            DemoQaUserPhoneNumber.SendKeys(UserPhoneNumber);
            UserBirthdayPicker();
            Thread.Sleep(5000);
            //DemoQaSubjects.SendKeys(UserSubjects);
            //Thread.Sleep(5000);
            DemoQaHobbies.SendKeys(Keys.Space);
            //Thread.Sleep(5000);
            DemoQaCurrentAddress.SendKeys(UserCurrentAddress);
            Thread.Sleep(5000);
            //DemoQaState.SendKeys(UserState);
            //Thread.Sleep(5000);
            //DemoQaCity.SendKeys(UserCity);
            //DemoQaSubmitButton.Click();
        }

        //DemoQA Textbox Form Actions
        public void TextBoxFormDemoQa()
        {
            DemoQaTextboxFullName.SendKeys(FullName);
            DemoQaUserEmail.SendKeys(UserEmail);
            DemoQaCurrentAddress.SendKeys(UserCurrentAddress);
            DemoQaTextboxPermanentAddress.SendKeys(PermanentAddress);
            DemoQaSubmitButton.Click();
        }

        public void UserBirthdayPicker()
        {
            DemoQaUserBirthDatePicker.Click();
            DemoQaUserBirthDateMonth.Click();
            DemoQaUserBirthDateYear.Click();
            DemoQaUserBirthDateDay.Click();
        }

        //CasQa SignUp
        public void FillSignUpFormCasQa()
        {
            CasQaFullNameTextBox.SendKeys(FullNameCasQa);
            CasQaEmailFieldTextBox.SendKeys(EmailCasQa);
            CasQaPhoneNumberTextBox.SendKeys(PhoneNumberCasQa);
            CasQaAddressTextBox.SendKeys(AddressCasQa);
            CasQaPasswordTextBox.SendKeys(PasswordCasQa);
            CasQaPasswordRepeatTextBox.SendKeys(PasswordCasQa);
            CasQaSubmitButton.Click();
        }

        public void LoginRegularUserCasQa()
        {
            Thread.Sleep(5000);
            CasQaEmailFieldTextBox.SendKeys(EmailCasQa);
            CasQaPasswordFieldTextBox.SendKeys(PasswordCasQa);
            CasQaSubmitButton.Click();
        }

        public void LoginUserCasQa(string userEmailCasqa, string userPasswordCasQa)
        {
            CasQaEmailFieldTextBox.SendKeys(userEmailCasqa);
            CasQaPasswordFieldTextBox.SendKeys(userPasswordCasQa);
            CasQaSubmitButton.Click();            
        }

        public void LoginIntoApplication(UserDto user)
        {
            //EmailFieldTextBox.SendKeys(user.userEmail);
            //PasswordFieldTextBox.SendKeys(user.userPassword);

            //var validUser = user.GetValidUser();
            //var userRuntimeProperties = user.GetType().GetRuntimeProperties(); //returns a collection
            //var userProperties = user.GetType().GetProperties(); //returns an array

            var emailValue = user.GetType().GetRuntimeProperty("userEmail").GetValue(user);
            if (emailValue != null)
            {
                CasQaEmailFieldTextBox.SendKeys(emailValue.ToString());
            }

            var passwordValue = user.GetType().GetRuntimeProperty("userPassword").GetValue(user);
            if (passwordValue != null)
            {
                CasQaPasswordFieldTextBox.SendKeys(passwordValue.ToString());
            }

            CasQaSubmitButton.Click();
        }

    }
}
