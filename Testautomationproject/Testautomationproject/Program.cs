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

// Go to administration and click time and material 
IWebElement Administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
Administration.Click();
    // create new time and material 
IWebElement TimeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
TimeAndMaterial.Click();
//Identify create new
IWebElement CreateNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
CreateNew.Click();
Thread.Sleep(3000);
//Input code Textbox
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("Books");
//Input Description Textbox
IWebElement DescrptionTextbox = driver.FindElement(By.Id("Description"));
DescrptionTextbox.SendKeys("Books2022");
//Input Price per unit Textbox
Thread.Sleep(1500);
IWebElement Pricetag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
Pricetag.Click();
IWebElement price = driver.FindElement(By.Id("Price"));
price.SendKeys("50");
//Click on save button
Thread.Sleep(2000);
IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
SaveButton.Click();
Thread.Sleep(5000);

//Go to last page
IWebElement GotoLastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
GotoLastpage.Click();
IWebElement newcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (newcode.Text == "Books" )
{
    Console.WriteLine("New material has been created successfully");
}
else
{
    Console.WriteLine("New Material record hasn't been created");
}





