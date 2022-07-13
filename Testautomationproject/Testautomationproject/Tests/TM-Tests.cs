

//open chrome browser
IWebDriver driver = new ChromeDriver();

//Login Page object Initialization and definition

LoginPage loginPageobj = new LoginPage();
loginPageobj.LoginActions(driver);

// HomePage object Initialization and definition

HomePage homePageobj = new HomePage();
homePageobj.GoToTMPage(driver);

// TMPage object Initialization and definition

TMPage tmPageobj = new TMPage();
tmPageobj.CreateTM(driver);

//Edit TM

tmPageobj.EditTM(driver);

//Delete TM

tmPageobj.DeleteTM(driver);

driver.Close();

