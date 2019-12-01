using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AddressBook
{
    public class TestBase
    {
        protected ApplicationManager app;
        
        [SetUp]
        public void SetUp()
        {
            app = new ApplicationManager();
        }
        [TearDown]
        public void TearDown()
        {
            app.Stop();
        }
        

        

        

        

       
    }
}
