using OpenQA.Selenium;
using System;

namespace AvivatecAutomationTest.PageObjects
{
    class SignInPage
    {
        private IWebDriver driver;
        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement registerMail => driver.FindElement(By.Id("email_create"));
        public IWebElement registerBtn => driver.FindElement(By.Id("SubmitCreate"));
        public IWebElement userEmail => driver.FindElement(By.Id("email"));
        public IWebElement userPass => driver.FindElement(By.Id("passwd"));
        public IWebElement signInBtn => driver.FindElement(By.Id("SubmitLogin"));

        public void SetEmailForRegister()
        {
            registerMail.SendKeys($"test{new Random().Next(10000, 99999).ToString()}@ts.com");
        }

        public void ClickRegisterBtn()
        {
            registerBtn.Click();
        }

        public void SetSignInMail()
        {
            userEmail.SendKeys("avivatec@test.com");
        }

        public void SetSignInPassword()
        {
            userPass.SendKeys("123Senh@");
        }

        public void Submit()
        {
            signInBtn.Click();
        }
    }
}
