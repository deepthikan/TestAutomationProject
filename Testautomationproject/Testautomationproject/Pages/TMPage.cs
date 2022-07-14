


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
            IWebElement newcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newcode.Text == "Books")
            {
                Console.WriteLine("New material has been created successfully.");
            }
            else
            {
                Console.WriteLine("New Material record hasn't been created.");
            }
        }

        public void EditTM(IWebDriver driver)
        {

            //click on edit button

            IWebElement Editbutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Editbutton.Click();
            Thread.Sleep(1500);
            //edit code textbox
            IWebElement editCodeButton = driver.FindElement(By.Id("Code"));
            editCodeButton.Clear();
            editCodeButton.SendKeys("Books Ed");
            //Edit Description
            IWebElement editDescription = driver.FindElement(By.Id("Description"));
            editDescription.Clear();
            editDescription.SendKeys("Books2022 Ed");
            //Edit New price
            WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]");

            IWebElement editPriceNew = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement editPrice = driver.FindElement(By.Id("Price"));
            editPriceNew.Click();
            editPrice.Clear();
            editPriceNew.Click();
            editPrice.SendKeys("550");
            //click Save Button
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(3000);
            //Go to last page

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(5000);
            //Validate updated Display message

            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text.Equals("Books Ed"))
            {
                Console.WriteLine("Material Updated Succesfully,Test Pass");
            }
            else

            {
                Console.WriteLine("Material has not been Updated, Test fail.");
            }
        }

        public void DeleteTM(IWebDriver driver)
        {
            // Delete material

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(1500);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(5000);

            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text.Equals("Books Ed"))
            {
                Console.WriteLine(" Material not deleted, Test fail.");
            }
            else

            {
                Console.WriteLine("Material deleted successfully, Test Pass.");
            }

        }




    }
}   