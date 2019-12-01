using System;
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
        protected LoginHelper auth;
        protected NavigateHelper navigator;
        protected GroupHelper group;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseUrl = "http://winerror.h1n.ru/index.php";
            auth = new LoginHelper(driver);
            navigator = new NavigateHelper(driver, baseUrl);
            group = new GroupHelper(driver);
            
        }
        public LoginHelper Auth { get; set; }
        public NavigateHelper Navigator { get; set; }
        public GroupHelper Group { get; set; }

        public void Stop()
        {
            driver.Quit();
        }
    }
}
