using OpenQA.Selenium;

namespace AvivatecAutomationTest.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement signInBtn => driver.FindElement(By.ClassName("login"));

        public void ClickSignInBtn()
        {
            signInBtn.Click();
        }
    }
}
