using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using SeleniumTest.src;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SeleniumTest

{
    public static class Functions
    {
        public static void LocateObject(this IWebDriver driver)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(Repository.WahooFitness.ShopObject(driver));
            actions.Perform();
            Console.WriteLine("Web moved to Item");
        }
        public static void GoToShop(this IWebDriver driver)
        {
            Repository.WahooFitness.ShopBtn(driver).Click();
            Console.WriteLine("Shop categorie opened");
        }
        public static void CheckSideCart(this IWebDriver driver)
        {
            var CartSide = driver.FindElement(By.ClassName("minicart-messages"), 5000);
            Console.WriteLine("Your Cart is opened");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            List<IWebElement> ShoppingCart = new List<IWebElement>();
            ShoppingCart.AddRange(driver.FindElements(By.ClassName("item")));

            if (ShoppingCart.Count > 0)
            {
                //If the count is greater than 0 your element exists.
                //elementList[0].Click();
                Console.WriteLine("There is/are " + ShoppingCart.Count + " elements in the cart");
            }
            else
            {
                Console.WriteLine("There are no elements present in the cart: " + ShoppingCart.Count);
            }

        }
        public static void DeleteSecondObject(this IWebDriver driver)
        {
            Repository.SideCart.RemoveBtn(driver).Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Repository.PopUpElements.OkBtn(driver).Click();
            Console.WriteLine("Shop categorie opened");
        }
        public static void PlaceOrder_Error(this IWebDriver driver)
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Repository.WahooFitness.PlaceOrderBtn(driver).Click();
            Console.WriteLine("Place Order clicked, not able to continue");
        }
        public static void ChangeShippingMethod(this IWebDriver driver)
        {            
            Repository.WahooFitness.ExpressShipping(driver).Click();
            Console.WriteLine("Shipping Method changed to Express Shipping");
        }
        public static void FillClientData(this IWebDriver driver)
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Repository.WahooFitness.EmailTxt(driver).SendKeys("someone@whocares.com");
            Console.WriteLine("Email Filled");
            Repository.WahooFitness.FirstNameTxt(driver).SendKeys("Test");
            Console.WriteLine("First Name Filled");
            Repository.WahooFitness.LastNameTxt(driver).SendKeys("Tester");
            Console.WriteLine("Last Name Filled");
            Repository.WahooFitness.AddressTxt(driver).SendKeys("Comandante Izarduy 67");
            Console.WriteLine("Street Address Filled");
            Repository.WahooFitness.CityTxt(driver).SendKeys("Barcelona");
            Console.WriteLine("City Filled");
            Repository.WahooFitness.PostalCode(driver).Clear();
            Repository.WahooFitness.PostalCode(driver).SendKeys("08940");
            Console.WriteLine("Postal Code");
            Repository.WahooFitness.PhoneTxt(driver).SendKeys("5555555555");
            Console.WriteLine("Phone Number");

            var Country = driver.FindElement(By.Name("country_id")); 
            var selectCountry = new SelectElement(Country);
            Repository.WahooFitness.CountryComboBox(driver).Click();
            Repository.WahooFitness.CountryComboBox(driver).SendKeys("Spain");
            selectCountry.SelectByText("Spain");
            Console.WriteLine("Country Filled");

            var Province = driver.FindElement(By.Name("country_id"));
            var selectProvince = new SelectElement(Province);
            Repository.WahooFitness.ProvinceComboBox(driver).Click();
            Repository.WahooFitness.ProvinceComboBox(driver).SendKeys("Barcelona");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            //selectProvince.SelectByValue("Barcelona");
            Console.WriteLine("Province Filled");
            //Repository.WahooFitness.ProvinceComboBox(driver).Click();
            //Repository.WahooFitness.ProvinceComboBox(driver).SendKeys("Barcelona");
            //builder.SendKeys(Keys.Enter);
        }
        public static void FillCreditCard(this IWebDriver driver)
        {

            Repository.WahooFitness.CreditCardNumber(driver).SendKeys("4111111111111111");
            Console.WriteLine("Email Filled");
            Repository.WahooFitness.CreditCardDate(driver).SendKeys("0824");
            Console.WriteLine("First Name Filled");
            Repository.WahooFitness.CreditCardCVC(driver).SendKeys("111");
            Console.WriteLine("Last Name Filled");
        }
    }
}