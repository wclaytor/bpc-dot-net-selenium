# bpc-dot-net-selenium

## Setup
```
dotnet new nunit
dotnet add package Selenium.WebDriver
dotnet add package Selenium.WebDriver.ChromeDriver
dotnet add package NUnit3TestAdapter
```

## Run
```
dotnet test
```

---

## What is the Usings.cs file and why is it needed?

The Usings.cs file is a workaround for a bug in the .NET Core CLI.  The bug is that the CLI does not support the `using static` directive.  The workaround is to create a file that contains the `using static` directives and then reference that file in the .csproj file.  The .csproj file is the project file for the .NET Core CLI.

The Usings.cs file is located in the root of the project.  It contains the following code:

```csharp
using static System.Console;
using static System.Math;
using static System.Convert;
using static System.String;
using static System.DateTime;
using static System.Environment;
...
```

---

##
When I run the following code I get the following error:

```csharp
namespace bpc_dot_net_selenium;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://demo.billclaytor.com");

        // Add your test automation code here

        driver.Quit();
    }
}
```

The error is:

```
ChromeDriver was started successfully.
Connection refused (localhost:57446)
```

-

The solution is to add the following code:

```csharp
ChromeOptions options = new ChromeOptions();
options.AddArgument("headless");
IWebDriver driver = new ChromeDriver(options);
```

Not headless:

-

The solution is to add the following code:

```csharp
ChromeOptions options = new ChromeOptions();
options.AddArgument("start-maximized");
IWebDriver driver = new ChromeDriver(options);
```

-
