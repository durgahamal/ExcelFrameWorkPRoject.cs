using ExcelFrameWorkPRoject.cs.Views;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ExcelFrameWorkPRoject.cs.Tests
{
    class LoginPageTest : BasePageTest
    {
        [Test]
        public void SignInAccountTest()
        {
            LoginPageView loginPageView = new LoginPageView();
            loginPageView.SetTextCreateEmail("standard_user");
            loginPageView.SetTextCreatePassword("secret_sauce");
            loginPageView.LoginButtonTest();
            loginPageView.AddToCartTest();
            loginPageView.GoToCartTest();
            loginPageView.RemoveTest();
            loginPageView.ContinueShoppingTest();
            loginPageView.Addonesie();
            loginPageView.GoToCartTest();
            loginPageView.ContionueShopTest();
            loginPageView.AddToCartTest();
            loginPageView.GoToCartTest();
            loginPageView.CheckoutTest();
            loginPageView.SetTextId("Zorba");
            loginPageView.SetTextLastName("Test");
            loginPageView.SetTextZipCode("12345");
            loginPageView.ContinueAfterMessage();
            loginPageView.ClickForFinishTest();
            Assert.AreEqual("THANK YOU FOR YOUR ORDER", loginPageView.GetTextForAfterClickFinishButton());
            Console.WriteLine(loginPageView.GetTextForAfterClickFinishButton());
            loginPageView.HamburgerMenuButton();
            loginPageView.LogoutTEst();



        }
        [Test]
        public void SecondScenarioLoginTest()
        {
            LoginPageView loginPageView = new LoginPageView();
            loginPageView.SetTextCreateEmail("standard_user");
            loginPageView.SetTextCreatePassword("secret_sauce");
            loginPageView.LoginButtonTest();
            loginPageView.GoToCartTest();
            loginPageView.CheckoutTest();
            loginPageView.ContinueAfterMessage();
            Assert.AreEqual("Error: First Name is required", loginPageView.GetTextErorMEssage());
            Console.WriteLine(loginPageView.GetTextErorMEssage());
            loginPageView.HamburgerMenuButton();
            loginPageView.LogoutTEst();
            
        }
        [Test]
        public void ThirdScenarioTest()
        {
            LoginPageView loginPageView = new LoginPageView();
            loginPageView.SetTextCreateEmail("standard_user");
            loginPageView.SetTextCreatePassword("secret_sauce");
            loginPageView.LoginButtonTest();
            loginPageView.CartTest();
            loginPageView.CheckoutTest();
            loginPageView.SetTextId("Zorba");
            loginPageView.SetTextLastName("Test");
            loginPageView.SetTextZipCode("12345");
            loginPageView.ContinueAfterMessage();
            loginPageView.ClickForFinishTest();




        }
        
    
        
    }
       

      
    
}    
