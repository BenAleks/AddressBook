﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AddressBook
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseUrl;
        private LoginHelper auth;
        private NavigateHelper navigator;
        private GroupHelper group;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseUrl = "http://winerror.h1n.ru/index.php";
            auth = new LoginHelper(this);
            navigator = new NavigateHelper(this, baseUrl);
            group = new GroupHelper(this);
            
        }
        public IWebDriver Driver
        {
            get
            {
                return driver;
            }

        }

        public NavigateHelper Navigator { get => navigator; set => navigator = value; }
        public GroupHelper Group { get => group; set => group = value; }
        public LoginHelper Auth { get => auth; set => auth = value; }

        public void Stop()
        {
            driver.Quit();
        }
    }
}
