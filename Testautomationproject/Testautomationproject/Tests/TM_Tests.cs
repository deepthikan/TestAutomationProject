
using NUnit.Framework;
using Testautomationproject.Utilities;

namespace Testautomationproject.Tests
{

    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginActions(driver);
            HomePage homepageobj = new HomePage();
            homepageobj.GoToTMPage(driver);
        }
        [Test, Order(1),Description("Check if user is able to create Material record with valid data")]
        public void CreateTM()
        {
            TMPage tmpageobj = new TMPage();
            tmpageobj.CreateTM(driver);
        }
        [Test, Order(2),Description("check if user is able to edit material record with valid data")]
        public void EditTM()
        {
            TMPage tmpageobj = new TMPage();
            tmpageobj.EditTM(driver,"po","p1","p2");
        } 
        [Test, Order(3), Description("check if user is able to delete material record")]
        public void DeleteTM()
        {
            TMPage tmpageobj = new TMPage();
            tmpageobj.DeleteTM(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
   