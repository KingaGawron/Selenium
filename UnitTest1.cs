using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium.BaseClass;
using System;
using System.Threading;

namespace Selenium
{
    [TestFixture]
    public class Tests:BaseTest
    {

        [Test, Category("Smoke Testing")]
        public void Test1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(1);
            element.SelectByText("maj");
            element.SelectByValue("6");
       
        }
        [Test, Category("Regression Testing")]
        public void Test2()
        {
            // IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='firstname']"));

            emailTextField.SendKeys("Selenium C#");

        }
        [Test, Category("Smoke Testing")]
        public void Test3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);

        }

    }
}