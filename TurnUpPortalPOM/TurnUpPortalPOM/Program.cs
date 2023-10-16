using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalPOM.Pages;

namespace TurnUpPortalPOM
{
    public class Program
    {
        private static void Main(String[] argus)
        {
            IWebDriver driver = new ChromeDriver();

            LoginPage loginObj = new LoginPage();
            loginObj.LoginActions(driver);

            HomePage homepageObj = new HomePage();
            homepageObj.VerifySucessLogin(driver);
            homepageObj.GoToTMPage(driver);

            TMPage tmpageObj = new TMPage();
            tmpageObj.EditTimeRecord(driver);
            tmpageObj.EditTimeRecord(driver);
            tmpageObj.DeleteTimeRecord(driver);



        }

    }
}
