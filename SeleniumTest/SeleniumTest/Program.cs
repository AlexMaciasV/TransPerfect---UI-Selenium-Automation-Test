using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumTest.src;
using System;
using System.Collections.Generic;
using SeleniumTest;
using System.Threading;

namespace SeleniumTest
{
     class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            //OpenURL

            driver.Navigate().GoToUrl("https://eu.wahoofitness.com/");
            driver.Manage().Window.Maximize();
            Console.WriteLine("Wahoofitness page has been opened");
            Repository.PopUpElements.CloseCookies(driver).Click();
            Functions.GoToShop(driver);
            Functions.LocateObject(driver);

            //AddItemToCart
            Repository.WahooFitness.ShopObject(driver).Click();
            Console.WriteLine("Shop Object Opened");
            Repository.WahooFitness.AddToCartBtn(driver).Click();
            Console.WriteLine("Add to Cart button clicked");

            Functions.CheckSideCart(driver);
            Repository.SideCart.CloseCart(driver).Click();
            Functions.GoToShop(driver);
            Functions.LocateObject(driver);

            //AddItemToCart
            Repository.WahooFitness.ShopObject2(driver).Click();
            Console.WriteLine("Shop Object Opened");
            Repository.WahooFitness.AddToCartBtn(driver).Click();
            Console.WriteLine("Add to Cart button clicked");
            
            
            Functions.CheckSideCart(driver);
            Functions.DeleteSecondObject(driver);
            Functions.CheckSideCart(driver);
            Repository.SideCart.EditCart(driver).Click();
            //CheckPrice
            string Price = driver.FindElement(By.XPath(".//*[@id='cart-totals']/div/table/tbody/tr[3]/td/strong/span")).GetAttribute("textContent");
            Console.WriteLine("The price is: " + Price);

            //ClearQuantityItems
            Repository.WahooFitness.QuantityTxtBox(driver).Clear();
            Repository.WahooFitness.QuantityTxtBox(driver).SendKeys("2");
            Repository.WahooFitness.UpdateCartBtn(driver).Click();
            //CheckPrice
            Price = driver.FindElement(By.XPath(".//*[@id='cart-totals']/div/table/tbody/tr[3]/td/strong/span")).GetAttribute("textContent");
            Console.WriteLine("The price is: " + Price);
            Repository.WahooFitness.CheckoutBtn(driver).Click();

            //Try to proceed with the shipping without client data
            Functions.PlaceOrder_Error(driver);
            //Change Shipping Method
            Functions.ChangeShippingMethod(driver);
            //Fill CLient Data
            Functions.FillClientData(driver);
            Functions.FillCreditCard(driver);
            
            Repository.WahooFitness.PlaceOrderBtn(driver).Click();

            driver.Close();
            Console.WriteLine("Test Case Finished");


        }
         

    }
}
