namespace bpc_dot_net_selenium;

public class Test
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void HomepageTest()
    {
        // options
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("start-maximized");

        // driver
        IWebDriver driver = new ChromeDriver(options);

        // navigate
        driver.Navigate().GoToUrl("http://demo.billclaytor.com");

        // title
        Assert.That(driver.Title, Is.EqualTo("Developer Bookshelf"));

        // quit
        driver.Quit();
    }
}