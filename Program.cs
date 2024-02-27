using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

public class DemantGetStarted
{
    private static void Main(string[] args)
    {
        IWebDriver driver = new FirefoxDriver();
        driver.Navigate().GoToUrl("https://www.demant.com/");

        var title = driver.Title; // information about browser
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500); //Waiting Stategies based on page load

        var acceptBox = driver.FindElement(By.CssSelector("[aria-label=\"I accept\"]"));
        acceptBox.Click();

        var aboutButton = driver.FindElement(By.ClassName("About"));
        aboutButton.Click();

        var managAndGovern = driver.FindElement(By.ClassName("Management and governance"));
        managAndGovern.Click();

        var text = driver.FindElement(By.ClassName(".like-h1-xl-light"));
        Assert.AreEqual("Executive Board and Board of Directors", text);

        var searchElement = driver.FindElement(By.ClassName("search"));
        searchElement.SendKeys("Remuneration report for 2021");
        searchElement.Click();

        var searchResult = driver.FindElement(By.ClassName("search-result"));
        Assert.AreEqual("Remuneration report 'for' 2021");

    }
}