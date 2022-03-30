using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnitTest
{
    public class Tests
    {
       IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
           //       driver = new InternetExplorerDriver();
            driver = new ChromeDriver("C:\\Users\\Stanislava1505\\source\\repos\\NUnitTest\\NUnitTest");
        }

        [Test]
        public void test()
        {
            //   driver.Url = "http://demo.guru99.com/test/ajax.html";


            //  driver.FindElement(By.Id("no")).Click();                        ex 1 
            // driver.FindElement(By.Id("buttoncheck")).Click();


            //     IList<IWebElement> el = driver.FindElements(By.Name("name"));         ex 2 

            //   for(int i = 0; i<el.Count(); i++)
            //   {
            //     Console.Write("Radio button " + el[i].GetAttribute("value"));
            // }

            driver.Url = "http://demo.guru99.com/test/login.html";
         //        var email = driver.FindElement(By.Id("email"));
          //       var password = driver.FindElement(By.Id("passwd"));

            //       email.SendKeys("abcd@gmail.com");
             //      password.SendKeys("abcdefghijkl");
               //    Console.WriteLine("Text Field Set");
            /*
                   email.Clear();
                    password.Clear();
                   Console.WriteLine("Text Field Cleared");

                   email.SendKeys("abcd@gmail.com");
                   password.SendKeys("abcdefghijkl");
            */
               //      driver.FindElement(By.Id("SubmitLogin")).Submit();
              
          
            driver.FindElement(By.Id("email")).SendKeys("abcd@gmail.com");
            driver.FindElement(By.Name("passwd")).SendKeys("abcdefghijkl");
            driver.FindElement(By.Id("SubmitLogin")).Click();
          //  Console.WriteLine("Login Done with Submit");


        }

        [TearDown]
        public void closeBrowser()
        {
        //    driver.Close();
        }
    }
}