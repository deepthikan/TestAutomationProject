using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testautomationproject.Utilities;

namespace Testautomationproject.Tests
{
    [TestFixture]
    public class Employee_Tests : CommonDriver
    {
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            LoginPage loginpageobj = new LoginPage();
            loginpageobj.LoginActions(driver);
            HomePage homepageobj = new HomePage();
            homepageobj.GoToEmployeepage(driver);
        }
        [Test, Order(1), Description("Check if user is able to create employee record with valid data")]
        public void CreateEmployee()
        {
            EmployeePage employeeobj = new EmployeePage();
            employeeobj.createEmployee(driver);
        }
        [Test, Order(2), Description("Check if user is able to edit employee record with valid data")]
        public void EditEmployee()
        {
            EmployeePage editemployeeobj = new EmployeePage();
            editemployeeobj.EditEmployee(driver, "p1","p2","p3","p4");
        }
        [Test, Order(3), Description("Check if user is able to delete employee record successfully")]
        public void DeleteEmployeeRecord()
        {
            EmployeePage DeleteEmployeeobj = new EmployeePage();
            DeleteEmployeeobj.DeleteEmployeeRecord(driver);
        }
        [TearDown]
        public void Testcloserun()
        {
           driver.Quit();
        }
    }
}