using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace OnlineWebapplication.Factory
{
    internal interface IBrowser
    {
        IWebDriver createDriver();
        
    }
}
