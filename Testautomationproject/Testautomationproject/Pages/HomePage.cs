
using NUnit.Framework;
using Testautomationproject.Utilities;

namespace Testautomationproject.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            try
            {
                // Go to administration and click time and material 
                IWebElement Administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
                Administration.Click();
                WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a");

                // create new time and material 
                IWebElement TimeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
                TimeAndMaterial.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("TM page is not responding", ex.Message);
            }
        }

        public void GoToEmployeepage(IWebDriver driver)
            {
                try
                {
                    // Go to administration and click time and material 
                    IWebElement Administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
                    Administration.Click();
                    WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a");

                    // create new time and material 
                    IWebElement GoToEmployeepage = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
                    GoToEmployeepage.Click();
                }
                catch (Exception ex)
                {
                    Assert.Fail("Employees page is not responding", ex.Message);
                }
        }
        
    }
}