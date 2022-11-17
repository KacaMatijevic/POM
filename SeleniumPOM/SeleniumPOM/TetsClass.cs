using NUnit.Framework;
using SeleniumPOM.Driver;
using SeleniumPOM.Page;

namespace SeleniumPOM;

public class TestClass
{
    private LoginPage loginPage;
    private HomePage homePage;

    [SetUp]

    public void BeforeScenario()
    {
        WebDriver.Initialize();
        loginPage = new LoginPage();
        homePage = new HomePage();

    }

    [TearDown]
    public void AfterScenario()
    {
        WebDriver.CleanUp();
    }


    [Test]

    public void TC01_FillInputWithValidData_ShouldAllDataDisplayedInInput()
    {

        Login("execute", "automation");
        homePage.Initial.SendKeys("KM");
        homePage.Title("Ms.");
        homePage.FirstName.SendKeys("Katarina");
        homePage.MiddleName.SendKeys("Matijevic");
        homePage.Female.Click();
        homePage.Hindi.Click();
        homePage.SaveButton.Click();
    }

    [Test]
    public void TC02_OpenPopUp_ShouldDisplayed()
    {
        Login("execute", "automation");
        homePage.HtmlPopup.Click();



    }


    [Test]
    public void TC03_OpenAlert_ShouldDisplayed()
    {
        Login("execute", "automation");
        homePage.Alert();

     
    }


    public void Login(string name, string pass)
    {
        loginPage.LoginOnPage(name, pass);
    }
}
