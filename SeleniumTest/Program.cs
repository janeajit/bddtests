using OpenQA.Selenium;
using System;
using System.Threading;


namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //indicate which browser we referencing
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            //navigate to the browser
            driver.Navigate().GoToUrl("https://www.google.com/");
            //identify the search box by right click on google searchbox and take the name of the element
            IWebElement ele = driver.FindElement(By.Name("q"));
            //pass the value in the google box
            ele.SendKeys("bbc");
            //element the google search button
            IWebElement googlesearch = driver.FindElement(By.Name("btnk"));
            //click on the googlesearch
            googlesearch.Click();
            Thread.Sleep(3000);
            driver.Close();
            Console.Write("test case ended ");

        }
    }
}
