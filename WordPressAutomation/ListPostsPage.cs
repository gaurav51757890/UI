﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressAutomation
{
    public class ListPostsPage
    {
        public static void GoTo(PostType postType)
        {
            switch(postType)
            {
                case PostType.Page:
                    Driver.Instance.FindElement(By.XPath("//span[.='My Site']")).Click();
                    Driver.Instance.FindElement(By.XPath("//span[.='Blog Posts']")).Click();
                    break;
            }
        }

        public static void SelectPost(string title)
        {
            var postLink = Driver.Instance.FindElement(By.LinkText("Sample Page"));
            postLink.Click();
        }
    }

    public enum PostType
    {
        Page
    }
}
