using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testautomationproject.Pages
{
    public class EmployeePage
    {
        public void createEmployee(IWebDriver driver)
        {
            //Identify Create 
            IWebElement CreateNewEmployee = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNewEmployee.Click();

            //Enter name
            IWebElement Name = driver.FindElement(By.Id("Name"));
            Name.SendKeys("Deepthi");

            //Enter username
            IWebElement UserName = driver.FindElement(By.Id("Username"));
            UserName.SendKeys("Dakshayani");
            //Enter password
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("@utomatioN12");
            //Retype Password
            IWebElement ReTypePassword = driver.FindElement(By.Id("RetypePassword"));
            ReTypePassword.SendKeys("@utomatioN12");
            //click on save button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            Thread.Sleep(2000);
            //go to back to list
            IWebElement GoBackToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            GoBackToList.Click();
            Thread.Sleep(2000);
            //go to last page
            IWebElement Gotolastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            Gotolastpage.Click();
            Thread.Sleep(2000);
            //check the record has been created
            IWebElement NameRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement UserNameRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            //Assertion
            Assert.That(NameRecord.Text == "Deepthi", "New employee record hasnt been created");
            Assert.That(UserNameRecord.Text == "Dakshayani", "New Username hasnt been created");

        }
        public void EditEmployee(IWebDriver driver)
        {
            Thread.Sleep(2000);
            //Go to last page
            IWebElement GotoLastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            GotoLastpage.Click();
            Thread.Sleep(2000);
            IWebElement findNewEmployeeCreated = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findNewEmployeeCreated.Text == "Deepthi")
            {
                //click on edit button
                IWebElement Editbutton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
                Editbutton.Click();
                Thread.Sleep(3000);
            }
            else

            {
                Assert.Fail("New Employee record hasnt been created");
            }
            //edit Name textbox
            IWebElement editNameTextBox = driver.FindElement(By.Id("Name"));
            editNameTextBox.Clear();
            editNameTextBox.SendKeys("DEEPTHI");

            //Edit Username
            IWebElement editUserName = driver.FindElement(By.Id("Username"));
            editUserName.Clear();
            editUserName.SendKeys("DAKSHAYANI");
            //Edit Password
            IWebElement editPassword = driver.FindElement(By.Id("Password"));
            editPassword.Clear();
            editPassword.SendKeys("@utomatioN12");
            //Retype Password
            IWebElement editReTypePassword = driver.FindElement(By.Id("RetypePassword"));
            editReTypePassword.Clear();
            editReTypePassword.SendKeys("@utomatioN12");
            //click on save button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            Thread.Sleep(2000);
            //go to back to list
            IWebElement GoBackToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            GoBackToList.Click();
            Thread.Sleep(2000);
            //go to last page
            IWebElement Gotolastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            Gotolastpage.Click();
            Thread.Sleep(2000);
            //check the edited employee record has been created
            IWebElement editedNameRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedUserNameRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            //Assertion
            Assert.That(editedNameRecord.Text == "DEEPTHI", "New employee record hasnt been edied");
            Assert.That(editedUserNameRecord.Text == "DAKSHAYANI", "New Username hasnt been edited");
        }
        public void DeleteEmployeeRecord(IWebDriver driver)
        {

            Thread.Sleep(2000);
            //click on GoToLastPage
            IWebElement GotoLastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            GotoLastpage.Click();
            Thread.Sleep(2000);
            // Delete Employee
            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span")).Click();
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            deleteButton.Click();
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(5000);
            //Go to last page
            driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(5000);

            //Validate updated Display message

            Thread.Sleep(10000);
            IWebElement DeleteemployeeName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement DeleteemployeeUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            //Assertion
            Assert.That(DeleteemployeeName.Text != "DEEPTHI", "Actual code and expected code do not match");

            Assert.That(DeleteemployeeUserName.Text != "DAKSHAYANI", "Actual Description and expected Description do not match");


        }


    }
}