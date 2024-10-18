using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineWebapplication.Factory;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OnlineWebapplication.Driver
{
    public class ChromeBrowser : IBrowser
    {
        public IWebDriver createDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--starts");
            return new ChromeDriver(options);
        }
    }
}
