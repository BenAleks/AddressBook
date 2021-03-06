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
public class GroupCreationTests: AuthTestBase
    {
    
    [Test]
    public void GroupCreationTest()
        {
            GroupData group = new GroupData("333");
            group.Header = "bbb";
            group.Footer = "ccc";

            
            app.Group.Create(group);
            
        }
    [Test]
    public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            app.Group.Create(group);
            
        }

    }
}