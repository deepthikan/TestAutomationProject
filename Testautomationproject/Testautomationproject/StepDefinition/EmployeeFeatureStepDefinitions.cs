using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using Testautomationproject.Utilities;

namespace Testautomationproject.StepDefinition
{
    [Binding]
    public class EmployeeFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginpageobj = new LoginPage();
        HomePage homepageobj = new HomePage();
        EmployeePage employeeobj = new EmployeePage();

        [Given(@"I logged into Turnup portal")]
        public void GivenILoggedIntoTurnupPortal()
        {

            driver = new ChromeDriver();
            loginpageobj.LoginActions(driver);

        }

        [When(@"I navigate to Employees page")]
        public void WhenINavigateToEmployeesPage()
        {
            homepageobj.GoToEmployeepage(driver);
        }

        [When(@"I create a new Employee record")]
        public void WhenICreateANewEmployeeRecord()
        {
            employeeobj.createEmployee(driver);
        }

        [Then(@"The employee record should be created successfully")]
        public void ThenTheEmployeeRecordShouldBeCreatedSuccessfully()
        {
            string newNameRecord = employeeobj.GetNameRecord(driver);
            string newUserNameRecord = employeeobj.GetUserNameRecord(driver);

            Assert.That(newNameRecord == "Deepthi", "New employee record hasnt been created");
            Assert.That(newUserNameRecord == "Dakshayani", "New Username hasnt been created");
            driver.Quit();
        }


        [When(@"I update '([^']*)','([^']*)','([^']*)' and '([^']*)' of an existing employee record")]
        public void WhenIUpdateAndOfAnExistingEmployeeRecord(string p0, string p1, string p2, string p3)
        {
            employeeobj.EditEmployee(driver, p0, p1, p2, p3);
        }

        [Then(@"The record '([^']*)','([^']*)','([^']*)' and '([^']*)' of an existing employee should be updated")]
        public void ThenTheRecordAndOfAnExistingEmployeeShouldBeUpdated(string p0, string p1, string p2, string p3)
        {
            string editedNameRecord = employeeobj.GetEditedNameRecord(driver);
            string editedUsenameRecord = employeeobj.GetEditedUsernameRecord(driver);

            Assert.That(editedNameRecord == p0, "New employee name hasnt been updated");
            Assert.That(editedUsenameRecord == p1, "New employee username hasnt been updated");
            driver.Quit();
        }
        [When(@"I delete an existing employee record")]
        public void WhenIDeleteAnExistingEmployeeRecord()
        {
            employeeobj.DeleteEmployeeRecord(driver);
        }

        [Then(@"The record should be deleted")]
        public void ThenTheRecordShouldBeDeleted()
        {
            try
            {
                string deletedNameRecord = employeeobj.GetDeletedEmployeeName(driver);
                string deletedUsernameRecord = employeeobj.GetDeletedUsername(driver);

                Assert.That(deletedNameRecord != "p0", "Actual name and expected name do not match");
                Assert.That(deletedUsernameRecord != "p1", "Actual username and expected username do not match");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                driver.Quit();
            }
        }

    }
}
