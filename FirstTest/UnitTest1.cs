
using FirstTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace FirstTest
{
    public class Tests
    {
        
        private IWebDriver driver;
        
       
        [SetUp]
        public void Setup()
        {
           
           driver = new ChromeDriver();
           driver.Navigate().GoToUrl("https://www.ccc.ua");
           driver.Manage().Window.Maximize();
        }

        [Test]
        public void GoToSignIn()

        {
          
            var mainMenu = new MainMenuPage(driver);
            mainMenu
           .ClickSignIn().EnterData("hinor88975@gocasin.com","1234wwwww");

            Thread.Sleep(300);
          
            string actualName = mainMenu.GetUserName();
            string expectedName = "w";
           

            Assert.AreEqual(expectedName, actualName, "Name is WRONG!!!");
        
            
        }
        [TearDown]
        public void TearDown() {
            driver.Quit();
        }
    }
}