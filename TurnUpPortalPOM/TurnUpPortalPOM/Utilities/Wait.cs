//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TurnUpPortalPOM.Utilities
//{
//    public class Wait
//    {

//        public static void WaitToBeClickable(IWebDriver driver, string locatorType, string locatorValue, int seconds)
//        {
//            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
//            if (locatorValue == "Xpath")
//            {
//                wait.Until(SeleniumExtras.WaitHelper.ExpectedConditions.ElementToBeClicable(By.XPath(locatorValue)));
//            }
//            if (locatorValue == "ID")
//            {
//                wait.Until(SeleniumExtras.WaitHelper.ExpectedConditions.ElementToBeClicable(By.XPath(locatorValue)));
//            }
//            if (locatorValue == "CssSelector")
//            {
//                wait.Until(SeleniumExtras.WaitHelper.ExpectedConditions.ElementToBeClicable(By.XPath(locatorValue)));
//            }
//            if (locatorValue == "Name")
//            {
//                wait.Until(SeleniumExtras.WaitHelper.ExpectedConditions.ElementToBeClicable(By.XPath(locatorValue)));
//            }

//        }

//       // public static void WaitToBeVisible(IWebDriver driver, string locatorType, string locatorValue, int second)




//    }
//}
