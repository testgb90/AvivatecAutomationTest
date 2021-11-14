using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AvivatecAutomationTest.PageObjects;
using AvivatecAutomationTest.Support;
using System;

namespace AvivatecAutomationTest
{
    public class Tests
    {
        private IWebDriver driver;
        private HomePage homePage;
        private FormPage formPage;
        private SignInPage signInPage;
        private ProfilePage profilePage;
        private Helper helper;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            homePage = new HomePage(driver);
            formPage = new FormPage(driver);
            signInPage = new SignInPage(driver);
            profilePage = new ProfilePage(driver);
            helper = new Helper();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "http://automationpractice.com/index.php";
        }

        [Test]
        public void ShouldCreateANewAccount()
        {
            helper.TakeScreenshot(driver, "Test 01 - Main page");
            homePage.ClickSignInBtn();
            signInPage.SetEmailForRegister();
            signInPage.ClickRegisterBtn();
            helper.TakeScreenshot(driver, "Test 01 - Register page");
            formPage.FillForm();
            Assert.AreEqual("MY ACCOUNT", profilePage.GetHeaderInfo());
            Assert.AreEqual("Daniel Anderson", profilePage.GetAccountName());
            helper.TakeScreenshot(driver, "Test 01 - User created");
        }

        [Test]
        public void ShouldSignInWithAValidAccount()
        {
            helper.TakeScreenshot(driver, "Test 02 - Main page");
            homePage.ClickSignInBtn();
            signInPage.SetSignInMail();
            signInPage.SetSignInPassword();
            helper.TakeScreenshot(driver, "Test 02 - Login page");
            signInPage.Submit();
            Assert.AreEqual("MY ACCOUNT", profilePage.GetHeaderInfo());
            Assert.AreEqual("Avivatec Tester", profilePage.GetAccountName());
            helper.TakeScreenshot(driver, "Test 02 - User logged into");
        }

        [Test]
        public void ShouldPresentAnAccountLoggedInto()
        {
            helper.TakeScreenshot(driver, "Test 03 - Main page");
            homePage.ClickSignInBtn();
            helper.TakeScreenshot(driver, "Test 03 - Login page");
            signInPage.SetSignInMail();
            signInPage.SetSignInPassword();
            signInPage.Submit();
            profilePage.ClickPersonalInfoBtn();
            Assert.AreEqual("YOUR PERSONAL INFORMATION", profilePage.GetPersonalInfoHeader());
            Assert.AreEqual("avivatec@test.com", formPage.GetAccountEmail());
            helper.TakeScreenshot(driver, "Test 03 - User logged into");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}