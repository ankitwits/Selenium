using OnlineWebApplication;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OnlineWebapplication.PageObjectModel
{
    internal class HomePage
    {
        private IWebElement txtname => Properties.driver.FindElement(By.Id(""));
        public void Anypagefunction()
        {

            txtname.SendKeys("testdata");

        
        }
    }
}
