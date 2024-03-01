using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Xunit;

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

        var webElement = driver.FindElement(By.ClassName(".like-h1-xl-light"));
        Assert.Equal("Executive Board and Board of Directors", webElement.Text);

        var searchElement = driver.FindElement(By.ClassName("search"));
        searchElement.SendKeys("Remuneration report for 2021");
        searchElement.Click();

        webElement = driver.FindElement(By.ClassName("search-result"));
        Assert.Equal("Remuneration report 'for' 2021", webElement.Text);

    }
}