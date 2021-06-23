using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstTest.PageObjects
{

    class SignInPage
    {

        private readonly By emailButton = By.XPath("//form[@id='login_form_id']//input[@name='user[email]']");
        private readonly By pusswordButton = By.XPath("//form[@id='login_form_id']//input[@name='user[pass]']");
        private readonly By enterButton = By.XPath("//form[@id='login_form_id']//dd[@class='form-item __submit']//input[@class='btn-input']");



        private IWebDriver _webDriver;

        public SignInPage(IWebDriver _webDriver)
        {
            this._webDriver = _webDriver;
        }
        public void EnterData(string email, string password)
        {
            _webDriver.FindElement(emailButton).SendKeys(email);
            _webDriver.FindElement(pusswordButton).Click();
            _webDriver.FindElement(pusswordButton).SendKeys(password);
            _webDriver.FindElement(enterButton).Click();

        }



    }
}
