﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AddressBook
{
    public class GroupHelper:HelperBase
    {
        public GroupHelper(ApplicationManager manager):base(manager)
        {}
        
        public GroupHelper Create(GroupData group)
        {
            manager.Navigator.GoToGroupPageq();
            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturToGroupPage();
            return this;
        }



        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;

        }

        public GroupHelper Remove(int v)
        {
            manager.Navigator.GoToGroupPageq();
            SelectGroup(v);
            SubmitGroupRemoval();
            ReturToGroupPage();
            return this;
        }

        public GroupHelper SubmitGroupRemoval()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }

        public GroupHelper SelectGroup(int indexer)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + indexer + "]")).Click();
            return this;
        }

        public GroupHelper Modify(int v, GroupData newData)
        {
            manager.Navigator.GoToGroupPageq();
            SelectGroup(v);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            ReturToGroupPage();
            return this;
        }

        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
        {

            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            
            return this;

        }

        

        public GroupHelper ReturToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }

        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;

        }
    }
}
