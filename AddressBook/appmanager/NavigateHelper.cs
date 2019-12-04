using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AddressBook
{
    public class NavigateHelper:HelperBase
    {
        private string baseUrl;
        public NavigateHelper(ApplicationManager manager, string baseUrl):base(manager)
        {
            this.baseUrl = baseUrl;
        }
        
        public NavigateHelper GoToGroupPageq()
        {
            driver.FindElement(By.LinkText("groups")).Click();
            return this;
        }
        public NavigateHelper GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseUrl);
            return this;
        }
    }
}
