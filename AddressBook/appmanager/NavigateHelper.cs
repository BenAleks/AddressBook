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
        public NavigateHelper(IWebDriver driver, string baseUrl):base(driver)
        {
            this.baseUrl = baseUrl;
        }
        public void ReturToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }
        public void GoToGroupPageq()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl("http://winerror.h1n.ru/index.php");
        }
    }
}
