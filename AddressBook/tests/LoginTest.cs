using System;

using NUnit.Framework;

namespace AddressBook
{
    [TestFixture]
    public class LoginTest:TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            app.Auth.Logout();
            AccountData account = new AccountData("admin","secret");
            app.Auth.Login(account);

            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }
        [Test]
        public void LoginWithInValidCredentials()
        {
            app.Auth.Logout();
            AccountData account = new AccountData("admin", "123666");
            app.Auth.Login(account);

            Assert.IsFalse(app.Auth.IsLoggedIn(account));
        }
    }
}
