

using Testautomationproject.Utilities;

namespace Testautomationproject.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            //launch turnup portal

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            //identify username textbox and enter valid username

            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            //identify password textbox and enter valid password

            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");
            WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "//*[@id='loginForm']/form/div[3]/input[1]");

            //identify login button and click it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

        }

    }
}