using AutomatonFrameworkproject1.Helper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelFrameWorkPRoject.cs.Views
{
    class IndexPageView
    {
        private const string logoclass = "login_logo";
        internal bool LogoIsPresent()
        {
            IWebElement logo = FrameWorkHelper.GetElement(logoclass, IdentifierType.ClassName);
            return logo.Displayed;
        }
    }
}
