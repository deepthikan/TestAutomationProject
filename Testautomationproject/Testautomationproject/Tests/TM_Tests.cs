
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
        [Test]
        public void CreateTM()
        {
            TMPage tmpageobj = new TMPage();
            tmpageobj.CreateTM(driver);
        }
        [Test]
        public void EditTM()
        {
            TMPage tmpageobj = new TMPage();
            tmpageobj.EditTM(driver);
        }
        [Test]
        public void DeleteTM()
        {
            TMPage tmpageobj = new TMPage();
            tmpageobj.DeleteTM(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {

        }
    }
}
   