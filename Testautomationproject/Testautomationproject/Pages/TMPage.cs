


using NUnit.Framework;
using Testautomationproject.Utilities;

namespace Testautomationproject.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
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
            Thread.Sleep(10000);
            //IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            //IWebElement newType = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            //IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            //IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            ////Assertion
            //Assert.That(newCode.Text == "Books", "Actual code and expected code do not match");
            //Assert.That(newType.Text == "M", "Actual Type and expected Type do not match");
            //Assert.That(newDescription.Text == "Books2022", "Actual Description and expected Description do not match");
            //Assert.That(newPrice.Text == "$50.00", "Actual price and expected price do not match");

        }
        public string GetCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }
        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;

        }
        public string GetPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;

        }

        public void EditTM(IWebDriver driver,string code,string description, string price)
        {
            Thread.Sleep(2000);
            //Go to last page
            IWebElement GotoLastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            GotoLastpage.Click();
            Thread.Sleep(2000);

            //click on edit button
            IWebElement Editbutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Editbutton.Click();
            Thread.Sleep(3000);

            //edit code textbox
            IWebElement editCodeButton = driver.FindElement(By.Id("Code"));
            editCodeButton.Clear();
            editCodeButton.SendKeys(code);

            //Edit Description
            IWebElement editDescription = driver.FindElement(By.Id("Description"));
            editDescription.Clear();
            editDescription.SendKeys(description);

            //Edit New price
            WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]");

            IWebElement editPriceNew = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement editPrice = driver.FindElement(By.Id("Price"));
            editPriceNew.Click();
            editPrice.Clear();
            editPriceNew.Click();
            editPrice.SendKeys(price);

            //click Save Button
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(3000);

            //Go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(5000);

            //Validate updated Display message

            Thread.Sleep(10000);

            
        }
        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement editedcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedcode.Text;
        }
        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedDescription.Text;
        }
        public string GetEditedPrice(IWebDriver driver)
        {
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return editedPrice.Text;
        }

        public void DeleteTM(IWebDriver driver)
        {
            
            Thread.Sleep(2000);
            //click on GoToLastPage
            IWebElement GotoLastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            GotoLastpage.Click();
            Thread.Sleep(2000);
            // Delete material
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(1500);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(5000);

            //Go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(5000);

            //Validate updated Display message

            Thread.Sleep(10000);
           

        }
        public string GetDeletedCode(IWebDriver driver)
        {
            IWebElement deletedcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return deletedcode.Text;
        }
        public string GetDeletedDescription(IWebDriver driver)
        {
            IWebElement GetDeletedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return GetDeletedDescription.Text;
        }
        public string GetDeletedPrice(IWebDriver driver)
        {
            IWebElement GetDeletedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return GetDeletedPrice.Text;
        }





    }
}   