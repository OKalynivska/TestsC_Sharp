using OpenQA.Selenium;
using System.Threading;


namespace FirstTest.PageObjects
{
    class MainMenuPage
    {
        private IWebDriver _webDriver;

        private readonly By _userIconSignIn = By.XPath("//div[@data-widget='userbar']");


        private readonly By userName = By.XPath("//div[@class='userbar userbar--user-outline-icon']/a/span");


        public MainMenuPage(IWebDriver _webDriver)
        {
            this._webDriver = _webDriver;
        }

        public SignInPage ClickSignIn()
        {
            _webDriver.FindElement(_userIconSignIn).Click();
            Thread.Sleep(300);
            return new SignInPage(_webDriver);
        }
        public string GetUserName() {
            string name = _webDriver.FindElement(userName).Text;
            return name.ToLower();
        }
    }
}
