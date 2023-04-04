using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace YourNamespace
{
    [TestFixture]
    [Binding]
    public class GoogleSearchSteps
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Given(@"I am on the Google search page")]
        public void GivenIAmOnTheGoogleSearchPage()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [When(@"I enter ""(.*)"" in the search box")]
        public void WhenIEnterInTheSearchBox(string keyword)
        {
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys(keyword);
        }

        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            IWebElement searchButton = driver.FindElement(By.Name("btnK"));
            searchButton.Click();
        }

        [Then(@"I should see search results for ""(.*)""")]
        public void ThenIShouldSeeSearchResultsFor(string keyword)
        {
            IWebElement searchResults = driver.FindElement(By.CssSelector("#search"));
            Assert.IsTrue(searchResults.Text.Contains(keyword));
        }
    }
}
