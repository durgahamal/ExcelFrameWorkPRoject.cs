using AutomatonFrameworkproject1.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelFrameWorkPRoject.cs.Views
{
    class LoginPageView
    {
        private const string userid = "user-name";
        private const string passwordxpath = "//input[@id='password']";
        private const string loginbuttonid = "login-button";
        private const string cartxpath = "//div[@class='inventory_item'][6]/descendant::button";
        private const string gotocartcss = ".svg-inline--fa.fa-shopping-cart.fa-w-18.fa-3x ";
       
        private const string removecss = ".btn_secondary.cart_button";
        private const string continueshoppingclassname = "btn_secondary";
        private const string onesieXpath = "//div[@class='inventory_item'][5]/descendant::button";
        private const string continueshoppingXpath = "//a[text()='Continue Shopping']";
        private const string checkoutcss = ".btn_action.checkout_button";
        private const string firstnameid = "first-name";
        private const string lastnameid = "last-name";
        private const string zipcodeid = "postal-code";
        private const string continuecss = ".btn_primary.cart_button";
        private const string finishbuttoncss = ".btn_action.cart_button";
        private const string finishtextxpath = "//h2[text()='THANK YOU FOR YOUR ORDER']";
        private const string hamburgerbuttonclass = "bm-burger-button";
        private const string logoutid = "logout_sidebar_link";
        private const string errormesagexpath = "//h3[text()='First Name is required']";
        private const string emptycartcss = ".svg-inline--fa.fa-shopping-cart.fa-w-18.fa-3x ";
       
        internal void SetTextCreateEmail(string email)
        {
            FrameWorkHelper.SetText(email, userid, IdentifierType.Id);

        }
        internal void SetTextCreatePassword(string password)
        {
            FrameWorkHelper.SetText(password, passwordxpath, IdentifierType.XPath);

        }
        internal void LoginButtonTest()
        {
            FrameWorkHelper.ClickElement(loginbuttonid, IdentifierType.Id);
        }
        internal void AddToCartTest()
        {
            FrameWorkHelper.ClickElement(cartxpath, IdentifierType.XPath);

        }
        internal void GoToCartTest()
        {
            FrameWorkHelper.ClickElement(gotocartcss, IdentifierType.CssSelector);
        }
        internal void RemoveTest()
        {
            FrameWorkHelper.ClickElement(removecss, IdentifierType.CssSelector);
        }
        internal void ContinueShoppingTest()
        {
            FrameWorkHelper.ClickElement(continueshoppingclassname, IdentifierType.ClassName);
        }
        internal void Addonesie()
        {
            FrameWorkHelper.ClickElement(onesieXpath, IdentifierType.XPath);
        }
        internal void ContionueShopTest()
        {
            FrameWorkHelper.ClickElement(continueshoppingXpath, IdentifierType.XPath);
        }
        internal void CheckoutTest()
        {
            FrameWorkHelper.ClickElement(checkoutcss, IdentifierType.CssSelector);
        }
        internal void SetTextId(string firstname)
        {
            FrameWorkHelper.SetText(firstname, firstnameid, IdentifierType.Id);
        }
        internal void SetTextLastName(string lastname)
        {
            FrameWorkHelper.SetText(lastname, lastnameid, IdentifierType.Id);
        }
        internal void SetTextZipCode(string zipcode)
        {
            FrameWorkHelper.SetText(zipcode, zipcodeid, IdentifierType.Id);
        }
        internal void ContinueAfterMessage()
        {
            FrameWorkHelper.ClickElement(continuecss, IdentifierType.CssSelector);


        }
        internal void ClickForFinishTest()
        {
            FrameWorkHelper.ClickElement(finishbuttoncss, IdentifierType.CssSelector);
        }
        internal string GetTextForAfterClickFinishButton()
        {
            return FrameWorkHelper.GetText(finishtextxpath, IdentifierType.XPath);
        }
        internal void HamburgerMenuButton()
        {
            FrameWorkHelper.ClickElement(hamburgerbuttonclass, IdentifierType.ClassName);

        }
        internal void LogoutTEst()
        {
            FrameWorkHelper.ClickElement(logoutid, IdentifierType.Id);
        }
        internal string GetTextErorMEssage()
        {
            return FrameWorkHelper.GetText(errormesagexpath, IdentifierType.XPath);
        }
        internal void CartTest()
        {
            FrameWorkHelper.ClickElement(emptycartcss, IdentifierType.CssSelector);
        }

        
    }
}   




    

        








        
    
       
    




    


    

  
