using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using Testautomationproject.Utilities;

namespace Testautomationproject.StepDefinition
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginpageobj = new LoginPage();
        HomePage homepageobj = new HomePage();
        TMPage tmpageobj = new TMPage();

        [Given(@"I logged into Turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();
            loginpageobj.LoginActions(driver);

        }

        [StepDefinition(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homepageobj.GoToTMPage(driver);
        }

        [When(@"I create a new Material record")]
        public void WhenICreateANewMaterialRecord()
        {
            tmpageobj.CreateTM(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tmpageobj.GetCode(driver);
            string newDescription = tmpageobj.GetDescription(driver);
            string newPrice = tmpageobj.GetPrice(driver);

            Assert.That(newCode == "Books", "Actual code and Expected code do not match");
            Assert.That(newDescription == "Books2022", "Actual description and Expected description do not match");
            Assert.That(newPrice == "$50.00", "Actual price and Expected price do not match");
            driver.Quit();
        }

        [When(@"I update '([^']*)','([^']*)' and '([^']*)' of an existing material record")]
        public void WhenIUpdateAndOfAnExistingMaterialRecord(string p0, string p1, string p2)
        {
            tmpageobj.EditTM(driver,p0,p1,p2);       
        }

        [Then(@"The record '([^']*)','([^']*)' and '([^']*)' of an existing material should be updated")]
        public void ThenTheRecordAndOfAnExistingMaterialShouldBeUpdated(string p0, string p1, string p2)
        {
            string editedCode = tmpageobj.GetEditedCode(driver);
            string editedDescription = tmpageobj.GetEditedDescription(driver);
            string editedPrice = tmpageobj.GetEditedPrice(driver);

            Assert.That(editedCode == p0, "Actual code and updated code do not match");
            Assert.That(editedDescription == p1, "Actual description and updated description do not match");
            Assert.That(editedPrice == p2, "Actual price and updated price do not match");
            driver.Quit();
        }

        [When(@"I delete an existing Material record")]
        public void WhenIDeleteAnExistingMaterialRecord()
        {
            tmpageobj.DeleteTM(driver);
        }

        [Then(@"The record should be deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully()
        {
            string deletedCode = tmpageobj.GetDeletedCode(driver);
            string deletedDescription = tmpageobj.GetDeletedDescription(driver);
            string deletedPrice = tmpageobj.GetDeletedPrice(driver);

            Assert.That(deletedCode != "p0", "Actual code and expected code do not match");
            Assert.That(deletedDescription != "p1", "Actual Description and expected Description do not match");
            Assert.That(deletedPrice != "p2", "Actual price and expected price do not match");
            driver.Quit();
        }




    }
}
