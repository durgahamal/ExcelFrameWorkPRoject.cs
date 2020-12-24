
using AutomatonFrameworkproject1.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;

namespace ExcelFrameWorkPRoject.cs.Tests
{
      class BasePageTest
      {
       
        [SetUp]
          public void BeforeTest()
          {
            //string path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\Drivers\chromedriver_win32 (2)");
            //FrameWorkHelper.WebDriver = new ChromeDriver(path);
            FrameWorkHelper.WebDriver = new ChromeDriver(@"C:\Drivers\chromedriver_win32 (2)");
            FrameWorkHelper.wait = new WebDriverWait(FrameWorkHelper.WebDriver, TimeSpan.FromSeconds(50));
            FrameWorkHelper.WebDriver.Manage().Window.Maximize();
            NavigateToUrl();
          }
          internal void NavigateToUrl()
          {
            FrameWorkHelper.WebDriver.Url = "https://www.saucedemo.com/index.html";

          }
          internal void AfterTest()
          {
            FrameWorkHelper.WebDriver.Quit();
          }
      }
}
