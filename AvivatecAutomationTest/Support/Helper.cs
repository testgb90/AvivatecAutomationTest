using System;
using OpenQA.Selenium;

namespace AvivatecAutomationTest.Support
{
    class Helper
    {
        private readonly string path = "D:\\Projects\\AvivatecAutomationTest\\AvivatecAutomationTest\\Screenshots\\";
        public string GetCurrentDate()
        {
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date.ToString("dd-MM-yyyy");
            return date;
        }

        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("HH-mm-ss");
        }

        public void TakeScreenshot(IWebDriver driver, string reference)
        {
            string dateFolder = $"{path}\\{GetCurrentDate()}";
            System.IO.Directory.CreateDirectory(dateFolder);
            Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile($"{dateFolder}\\{reference} - {GetCurrentTime()}.png", ScreenshotImageFormat.Png);
        }
    }
}
