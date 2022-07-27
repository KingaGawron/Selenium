using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium.BaseClass;
using Selenium.Utilities;
using System;
using System.Threading;

//[assembly: Parallelizable(ParallelScope.Children)]
//[assembly: LevelOfParallelism(10)]
namespace Selenium
{
    [TestFixture]
    public class ParallelTesting 
    {
        IWebDriver driver;

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test1()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test3()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test4()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test5()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test6()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test7()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test8()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test9()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test10()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

    }
}