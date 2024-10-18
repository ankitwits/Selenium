using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OnlineWebapplication.Factory;

namespace OnlineWebapplication.Factory
{
    internal class Chrome : IBrowser
    {
        public IWebDriver createDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--starts");
            return new ChromeDriver(options);
        }
    }
}
