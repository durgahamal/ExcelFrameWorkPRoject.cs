using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelFrameWorkPRoject.cs.Helper
{
    public enum IdentifierType
    {
        Id,
        Name,
        ClassName,
        LinkText,
        PartialLinkText,
        TagName,
        CssSelector,
        Xpath
    }
     public static class FrameWorkHelper
    {
        //class member
        private static IWebDriver _webDriver;
        public static WebDriverWait wait;
        internal static IJavaScriptExecutor javaScriptExecutor;
        //property
        public static IWebDriver WebDriver
        {
            get
            {
                return _webDriver;
            }
            set
            {
                _webDriver = value;
                javaScriptExecutor = (IJavaScriptExecutor)value;
            }  
            
        
        }
        public static IWebElement GetElement(string locator, IdentifierType identifierType)
        {
            IWebElement element = null;
            switch (identifierType)
            {
                case IdentifierType.Id:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator)));
                    element = WebDriver.FindElement(By.Id(locator));
                    break;
                case IdentifierType.Name:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locator)));
                    element = WebDriver.FindElement(By.Name(locator));
                    break;
                case IdentifierType.ClassName:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(locator)));
                    element = WebDriver.FindElement(By.ClassName(locator));
                    break;
                case IdentifierType.PartialLinkText:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locator)));
                    element = WebDriver.FindElement(By.LinkText(locator));
                    break;
                case IdentifierType.LinkText:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locator)));
                    element= WebDriver.FindElement(By.LinkText(locator));
                    break;
                case IdentifierType.TagName:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(locator)));
                    element = WebDriver.FindElement(By.TagName(locator));
                    break;
                case IdentifierType.CssSelector:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator)));
                    element = WebDriver.FindElement(By.CssSelector(locator));
                    break;
                case IdentifierType.Xpath:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
                    element = WebDriver.FindElement(By.XPath(locator));
                    break;



            }
            return element;
        }
        public static void SetText(string text, string locator,IdentifierType identifierType)
        {
            IWebElement element = GetElement(locator, identifierType);
            element.SendKeys(text);
        }
        public static void SetTextUsingJavaScriptExecutor(string text, IWebElement element)
        {
            javaScriptExecutor.ExecuteScript("arguments[0].value='" + text + ",", element);
        }
          public static string GetText(string locator ,IdentifierType identifierType)
        {
            IWebElement element = GetElement(locator, identifierType);
            return element.Text;
        }
        public static void ClickElement(string locator ,IdentifierType identifierType)
        {
            IWebElement element = GetElement(locator, identifierType);
                element.Click();
        }
        public static string GetTextUsingJavaScriptExecutor(IWebElement element)
        {
            return javaScriptExecutor.ExecuteScript("return arguments[0].value", element).ToString();
        }
        public static string GetPageTitle()
        {
            return WebDriver.Title;
        }
        public static void ScrollToElement(IWebElement element)
        {
            javaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView()", element);
        }
         public static void ScrollToEndPage()
        {
            Actions action = new Actions(_webDriver);
            action.SendKeys(Keys.Control).SendKeys(Keys.End).Perform();

        }  
        public static void ScrollToTopOfPage()
        {
            Actions action = new Actions(_webDriver);
            action.SendKeys(Keys.Control).SendKeys(Keys.Home).Perform();
                
        }
            
            

        
     }
}
    
    

