using OpenQA.Selenium;

namespace SeleniumTest.src
{
    class Repository
    {
        public static class WahooFitness
        {
            public static IWebElement ShopBtn(IWebDriver driver)
            {
                IWebElement ShopBtn = null;
                ShopBtn = driver.FindElement(By.XPath(".//*[@id='top_nav']/ul/li[1]/a"));
                return ShopBtn;

            }
            public static IWebElement ShopObject(IWebDriver driver)
            {
                IWebElement ShopObject = null;
                ShopObject = driver.FindElement(By.XPath(".//*[@id='section-4']/div/div/ul/li[5]/div[1]/a"));
                return ShopObject;

            }
            public static IWebElement ShopObject2(IWebDriver driver)
            {
                IWebElement ShopObject2 = null;
                ShopObject2 = driver.FindElement(By.XPath(".//*[@id='section-4']/div/div/ul/li[6]/div[1]/a"));
                return ShopObject2;
            }
            public static IWebElement AddToCartBtn(IWebDriver driver)
            {
                IWebElement AddToCartBtn = null;
                AddToCartBtn = driver.FindElement(By.Id("product-addtocart-button"));
                return AddToCartBtn;
            }
            public static IWebElement QuantityTxtBox(IWebDriver driver)
            {
                IWebElement QuantityTxtBox = null;
                QuantityTxtBox = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/main/div[3]/div/div[4]/form/div[1]/table/tbody/tr[1]/td[3]/div/div/input"));
                return QuantityTxtBox;

            }
            public static IWebElement UpdateCartBtn(IWebDriver driver)
            {
                IWebElement UpdateCartBtn = null;
                UpdateCartBtn = driver.FindElement(By.XPath(".//*[@id='form-validate']/div[2]/div/button/span"));
                return UpdateCartBtn;
            }
            public static IWebElement CheckoutBtn(IWebDriver driver)
            {
                IWebElement CheckoutBtn = null;
                CheckoutBtn = driver.FindElement(By.XPath(".//*[@id='maincontent']/div[3]/div/div[4]/div[1]/ul/li[1]/button"));
                return CheckoutBtn;
            }
            public static IWebElement PlaceOrderBtn(IWebDriver driver)
            {
                IWebElement PlaceOrderBtn = null;
                PlaceOrderBtn = driver.FindElement(By.XPath(".//*[@id='checkout']/div[4]/div[3]/div/div/div[6]/div/div/button"));
                return PlaceOrderBtn;
            }
            public static IWebElement ExpressShipping(IWebDriver driver)
            {
                IWebElement ExpressShipping = null;
                ExpressShipping = driver.FindElement(By.XPath(".//*[@id='s_method_amstrates_amstrates22']"));
                return ExpressShipping;
            }
            public static IWebElement EmailTxt(IWebDriver driver)
            {
                IWebElement EmailTxt = null;
                EmailTxt = driver.FindElement(By.Id("customer-email"));
                return EmailTxt;
            }
            public static IWebElement FirstNameTxt(IWebDriver driver)
            {
                IWebElement FirstNameTxt = null;
                FirstNameTxt = driver.FindElement(By.Name("firstname"));
                return FirstNameTxt;
            }
            public static IWebElement LastNameTxt(IWebDriver driver)
            {
                IWebElement LastNameTxt = null;
                LastNameTxt = driver.FindElement(By.Name("lastname"));
                return LastNameTxt;
            }
            public static IWebElement AddressTxt(IWebDriver driver)
            {
                IWebElement LastNameTxt = null;
                LastNameTxt = driver.FindElement(By.Name("street[0]"));
                return LastNameTxt;
            }
            public static IWebElement CityTxt(IWebDriver driver)
            {
                IWebElement CityTxt = null;
                CityTxt = driver.FindElement(By.Name("city"));
                return CityTxt;
            }
            public static IWebElement PostalCode(IWebDriver driver)
            {
                IWebElement PostalCode = null;
                PostalCode = driver.FindElement(By.Name("postcode"));
                return PostalCode;
            }
            public static IWebElement PhoneTxt(IWebDriver driver)
            {
                IWebElement PhoneTxt = null;
                PhoneTxt = driver.FindElement(By.Name("telephone"));
                return PhoneTxt;
            }
            public static IWebElement CountryComboBox(IWebDriver driver)
            {
                IWebElement PhoneTxt = null;
                PhoneTxt = driver.FindElement(By.Name("country_id"));
                return PhoneTxt;
            }
            public static IWebElement ProvinceComboBox(IWebDriver driver)
            {
                IWebElement PhoneTxt = null;
                PhoneTxt = driver.FindElement(By.Name("region_id"));
                return PhoneTxt;
            }
            public static IWebElement CreditCardNumber(IWebDriver driver)
            {
                IWebElement CreditCardNumber = null;
                CreditCardNumber = driver.FindElement(By.Name("cardNumber"));
                return CreditCardNumber;
            }
            public static IWebElement CreditCardDate(IWebDriver driver)
            {
                IWebElement CreditCardDate = null;
                CreditCardDate = driver.FindElement(By.Name("cardExpiry"));
                return CreditCardDate;
            }
            public static IWebElement CreditCardCVC(IWebDriver driver)
            {
                IWebElement CreditCardCVC = null;
                CreditCardCVC = driver.FindElement(By.Name("cardCvc"));
                return CreditCardCVC;
            }
        }
        public static class PopUpElements
        {
            public static IWebElement CloseCookies(IWebDriver driver)
            {
                IWebElement CloseCookies = null;
                CloseCookies = driver.FindElement(By.Id("onetrust-close-btn-container"));
                return CloseCookies;

            }
            public static IWebElement OkBtn(IWebDriver driver)
            {
                IWebElement OkBtn = null;
                OkBtn = driver.FindElement(By.XPath("/html/body/div[12]/aside[2]/div[2]/footer/button[2]/span"));
                return OkBtn;
            }


        }
        public static class SideCart
        {
            public static IWebElement CloseCart(IWebDriver driver)
            {
                IWebElement CloseCart = null;
                CloseCart = driver.FindElement(By.Id("btn-minicart-close"));
                return CloseCart;

            }
            public static IWebElement RemoveBtn(IWebDriver driver)
            {
                IWebElement RemoveBtn = null;
                RemoveBtn = driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div/div/div/div[2]/div[1]/ol/li[2]/div/div/div[3]/div/a/span"));
                return RemoveBtn;

            }
            public static IWebElement EditCart(IWebDriver driver)
            {
                IWebElement EditCart = null;
                EditCart = driver.FindElement(By.XPath("//*[@id='minicart-content-wrapper']/div[2]/div[4]/div/a/span"));
                return EditCart;

            }
        }
    }
}
