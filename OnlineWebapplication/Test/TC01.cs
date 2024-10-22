using OpenQA.Selenium;
using OnlineWebapplication.Factory;
using OpenQA.Selenium.Support.UI;

namespace OnlineWebApplication.Test
{
    [TestClass]
    public class TC01
    {
        IBrowser browserType;


        [TestMethod]
        public void TestMethod1()
        {
            string browsertype = "chrome";

            browserType = BrowserFactory.GetBrowser(browsertype);
            IWebDriver driver = browserType.createDriver();
            driver.Navigate().GoToUrl("https://techglory.godaddysites.com/");

            SelectElement drpse = new SelectElement(driver.FindElement(By.Id("dropdownid")));

            drpse.SelectByText("Test");

            //ASSSert: how we perform validation

            //Assert :
            var element = driver.FindElements(By.Id("")).Count;
            Assert.AreEqual(1, element);

            var btninput = driver.FindElements(By.XPath("//input[@value='login']"));//input as tag, login as attribute

            //if xpath ia an absolute path that is not the good way because that can change its better to
            //put relative xpath will make sure that the property of the element does not changes.

            //identification of validation text that popup in case there is no data entered
            var error = driver.FindElement(By.XPath("")).Text;
            Assert.AreEqual("this field is required", error);
        }
    }
}