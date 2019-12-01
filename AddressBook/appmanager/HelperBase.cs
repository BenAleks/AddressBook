using OpenQA.Selenium;
namespace AddressBook
{
    public class HelperBase
    {
        protected IWebDriver driver;
        public HelperBase(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
}