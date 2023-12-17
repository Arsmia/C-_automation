using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumDocs.GettingStarted
{
    public class UsingSeleniumTest
    {   public void CheckDemantWebSite()
      IWebDriver driver = new FirefoxDriver();
      driver.Navigate().GoToUrl('http://   ");
      var title = driver.Title;
      Assert.AreEqual("Title_name", title);
      driver.Manage().Timeouts().ImplicitWait=Timespan.FromMilliseconds(500);
      var textBox = driver.FindElement(By.TagName("button"));
      var submitButton = driver.FindElement(By.TagName("button"));

      textBox.SendKeys("Selenium");
      submitButton.Click();

      var message = driver.FindElement(By.ID("message"));
      var value = message.Test;
      Assert.AreEqual("Received!", value);

      driver.Quiat();
      }  
    }
}
