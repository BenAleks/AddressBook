﻿// Generated by Selenium IDE
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
[TestFixture]
public class GroupCreationTests:TestBase
     {
    
    [Test]
    public void GroupCreationTest()
        {
            app.Navigator.GoToHomePage();            
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupPageq();
            app.Group.InitGroupCreation();
            GroupData group = new GroupData("aaa");
            group.Header = "bbb";
            group.Footer = "ccc";
            app.Group
                .FillGroupForm(group)
                .SubmitGroupCreation()
                .ReturToGroupPage();
            app.Stop();
        }

        
    }
}