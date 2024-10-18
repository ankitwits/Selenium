using OpenQA.Selenium;
using OnlineWebapplication.Factory;

namespace OnlineWebapplication
{
    [TestClass]
    public class UnitTest1
    {
        IBrowser browserType;


        [TestMethod]
        public void TestMethod1()
        {
            string browsertype = "chrome";

           browserType = BrowserFactory.GetBrowser(browsertype);
           IWebDriver driver = browserType.createDriver();

            driver.Navigate().GoToUrl("https://techglory.godaddysites.com/");






            

        }
    }
}