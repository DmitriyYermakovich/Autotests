using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Project_Yermakovich_1.Tests
{
    public class HBCTest
    {
        [Test]
        public void NBC()
        {
            Assert.That(true, Is.True);
        }
        [Test]
        public void SeleniumTest()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.nbc.com");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
            driver.Quit();
        }

    }

}