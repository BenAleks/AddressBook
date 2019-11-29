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
        protected IWebDriver driver;
        protected string baseUrl = "http://winerror.h1n.ru/index.php";
        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();

        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        protected void ReturToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }

        protected void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        protected void FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }

        protected void InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }

        protected void GoToGroupPageq()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        protected void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.CssSelector("input:nth-child(7)")).Click();
        }

        protected void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseUrl);
        }
    }
}
