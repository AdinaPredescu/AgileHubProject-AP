using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTestsProject_AP.Enums;

namespace SeleniumTestsProject_AP.Data
{
    public static class TestEnvData
    {
        public const string DemoSiteCasQaBaseUrl = "http://demosite.casqad.org/";
        public const string GoogleHomePageBaseUrl = "https://www.google.com";
        public const string DemoQaAutomationFormBaseUrl = "https://demoqa.com/automation-practice-form";
        public const string DemoQaTextBoxBaseUrl = "https://demoqa.com/text-box";
        public const string TeatrulSicaAlexandrescuBaseUrl = "https://www.teatrulsicaalexandrescu.ro/?lang=en";
        public const string UntoldBaseUrl = "https://untold.com/";

        public static string GetBaseUrl(TestEnvironments testEnv)
        {
            switch (testEnv)
            {
                case TestEnvironments.DemoSiteCasQa:
                    return DemoSiteCasQaBaseUrl;
                case TestEnvironments.GoogleHomePage:
                    return GoogleHomePageBaseUrl;
                case TestEnvironments.DemoQaAutomationForm:
                    return DemoQaAutomationFormBaseUrl;
                case TestEnvironments.DemoQaTextBox:
                    return DemoQaTextBoxBaseUrl;
                case TestEnvironments.TeatrulSicaAlexandrescu:
                    return TeatrulSicaAlexandrescuBaseUrl;
                case TestEnvironments.Untold:
                    return UntoldBaseUrl;
                default:
                    throw new ArgumentException("TestEnvData: testEnv not known");
            }
        }
    }
}
