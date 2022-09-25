using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using Selenium.BaseClass;
using System;
using System.Threading;

namespace Selenium
{
    [TestFixture]
    public class OrderSkipAttribute
    {

        [Test, Order(2), Category("OrderSkipAttribute")]
        public void Test1()
        {
            Assert.Ignore("Defect 1234");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/r.php?locale=pl_PL";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();

        }
        [Test, Order(1), Category("OrderSkipAttribute")]
        public void Test2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/r.php?locale=pl_PL";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();

        }
        
        [Test, Order(0), Category("OrderSkipAttribute")]
        public void Test3()
        {
           
            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://www.facebook.com/r.php?locale=pl_PL";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='firstname']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();

        }


    }
}