using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AvivatecAutomationTest.PageObjects
{
    class FormPage
    {
        private IWebDriver driver;
        public FormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement title => driver.FindElement(By.Id("id_gender1"));
        public IWebElement firstName => driver.FindElement(By.Id("customer_firstname"));
        public IWebElement lastName => driver.FindElement(By.Id("customer_lastname"));
        public IWebElement password => driver.FindElement(By.Id("passwd"));
        public IWebElement selectDay => driver.FindElement(By.Id("days"));
        public IWebElement selectMonth => driver.FindElement(By.Id("months"));
        public IWebElement selectYear => driver.FindElement(By.Id("years"));
        public IWebElement address => driver.FindElement(By.Id("address1"));
        public IWebElement city => driver.FindElement(By.Id("city"));
        public IWebElement selectState => driver.FindElement(By.Id("id_state"));
        public IWebElement zip => driver.FindElement(By.Id("postcode"));
        public IWebElement mobilePhone => driver.FindElement(By.Id("phone_mobile"));
        public IWebElement submitButton => driver.FindElement(By.Id("submitAccount"));
        public IWebElement accountEmail => driver.FindElement(By.Id("email"));

        public void SetTitle()
        {
            title.Click();
        }

        public void SetFirstName(string value)
        {
            firstName.SendKeys(value);
        }

        public void SetLastName(string value)
        {
            lastName.SendKeys(value);
        }

        public void SetPassword(string value)
        {
            password.SendKeys(value);
        }

        public void SetDay(string value)
        {
            var selectObject = new SelectElement(selectDay);
            selectObject.SelectByValue(value);
        }

        public void SetMonth(string value)
        {
            var selectObject = new SelectElement(selectMonth);
            selectObject.SelectByValue(value);
        }

        public void SetYear(string value)
        {
            var selectObject = new SelectElement(selectYear);
            selectObject.SelectByValue(value);
        }

        public void SetAddress(string value)
        {
            address.SendKeys(value);
        }

        public void SetCity(string value)
        {
            city.SendKeys(value);
        }

        public void SetState(string value)
        {
            var selectObject = new SelectElement(selectState);
            selectObject.SelectByText(value);
        }

        public void SetZip(string value)
        {
            zip.SendKeys(value);
        }

        public void SetMobile(string value)
        {
            mobilePhone.SendKeys(value);
        }

        public void SubmitForm()
        {
            submitButton.Click();
        }

        public string GetAccountEmail()
        {
            return accountEmail.GetAttribute("value");
        }

        public void FillForm()
        {
            SetTitle();
            SetFirstName("Daniel");
            SetLastName("Anderson");
            SetPassword("123Senh@");
            SetDay("4");
            SetMonth("6");
            SetYear("2010");
            SetAddress("Florida Avenue");
            SetCity("Washington");
            SetState("Iowa");
            SetZip("55126");
            SetMobile("+5511946625519");
            SubmitForm();
        }

    }
}
