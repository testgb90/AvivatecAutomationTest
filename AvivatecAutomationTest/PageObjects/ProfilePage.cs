using OpenQA.Selenium;

namespace AvivatecAutomationTest.PageObjects
{
    class ProfilePage
    {
        private IWebDriver driver;
        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement headerInfo => driver.FindElement(By.XPath("//h1[@class='page-heading']"));
        public IWebElement accountName => driver.FindElement(By.ClassName("account"));
        public IWebElement personalInfoBtn => driver.FindElement(By.XPath("//span[contains(text(),'My personal information')]"));
        public IWebElement personalInfoHeader => driver.FindElement(By.XPath("//h1[@class='page-subheading']"));

        public string GetHeaderInfo()
        {
            return headerInfo.Text;
        }

        public string GetAccountName()
        {
            return accountName.Text;
        }

        public void ClickPersonalInfoBtn()
        {
            personalInfoBtn.Click();
        }

        public string GetPersonalInfoHeader()
        {
            return personalInfoHeader.Text;
        }

    }
}
