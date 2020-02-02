using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";
            driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[3]/center/input[2]")).Click();
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();

            IWebElement webElement = driver.FindElement(By.Id("searchinput"));
            webElement.Click();
            webElement.SendKeys("New Zealand");
            driver.FindElement(By.Id("searchbtn")).Click();

            IWebElement webContent =  driver.FindElement(By.XPath("//*[@id='archive-link']/a"));
            String title = webContent.Text;
            Console.WriteLine("The title of the element is: " + title);

        }
    }
}
