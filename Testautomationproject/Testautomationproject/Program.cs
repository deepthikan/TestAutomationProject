using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open chrome browser

IWebDriver driver = new ChromeDriver();

//launch turnup portal

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
driver.Manage().Window.Maximize();
//identify username textbox and enter valid username

IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");
//identify password textbox and enter valid password

IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");
//identify login button and click it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")); 
loginButton.Click();

//check user logged in successfully
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (hellohari.Text == "Hello hari!")
{
    Console.WriteLine("logged in successfully,test passed");
}
else
{
    Console.WriteLine("failed login,test failed");
}








