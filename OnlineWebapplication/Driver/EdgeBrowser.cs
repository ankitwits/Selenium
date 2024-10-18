using OnlineWebapplication.Factory;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;


namespace OnlineWebapplication.Driver
{
    internal class EdgeBrowser : IBrowser
    {
        public IWebDriver createDriver()
        {
            return new EdgeDriver();  
             

        }
    }
}
