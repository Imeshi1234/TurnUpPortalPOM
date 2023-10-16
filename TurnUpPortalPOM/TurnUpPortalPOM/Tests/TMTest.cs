//using NUnit.Framework;
//using OpenQA.Selenium.Chrome;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TurnUpPortalPOM.Pages;
//using TurnUpPortalPOM.Utilities;

//[TestFixture]
//public class TMTests : CommonDrivers
//{

//    [SetUp]
//    public void SetUpTM()
//    {
//        //open chrome browser
//        driver = new ChromeDriver();

//        //LoginPage object initialization and definition
//        LoginPage loginPageobj = new LoginPage();
//        loginPageobj.LoginActions(driver);

//        //HomePage object initialization and definition
//        HomePage homePageobj = new HomePage();
//        homePageobj.VerifySucessLogin(driver);
//        homePageobj.GoToTMPage(driver);

//    }

//    [Test, Order(1), Description(" This test creates a new time/Material record")]
//    public void TestCreateTimeRecord()
//    {
//        //TMPage object initialization and definition
//        TMPage tmPageobj = new TMPage();
//        tmPageobj.CreateTimeRecord(driver);
//    }

//    [Test, Order(2), Description(" This test Updates a new time/Material record")]
//    public void TestEditTMRecord()
//    {
//        TMPage tmPageobj = new TMPage();
//        tmPageobj.EditTimeRecord(driver);
//    }

//    [Test, Order(3), Description(" This test deletes a new time/Material record")]
//    public void TestDeleteTimeRecord()
//    {
//        TMPage tmPageobj = new TMPage();
//        tmPageobj.DeleteTimeRecord(driver);
//    }

//    [TearDown]
//    public void CloseTestRun()
//    {
//        driver.Close();
//    }



//}