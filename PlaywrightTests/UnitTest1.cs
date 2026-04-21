using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Test : PageTest
{
    [Test]
    public async Task HasTitle()
    {
        await Page.GotoAsync("http://localhost:5000/");

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync("Home");
    }

    [Test]
    public async Task GetStartedLink()
    {
        await Page.GotoAsync("http://localhost:5000/");

        // Click the get started link.
        await Page.GetByRole(AriaRole.Link, new() { Name = "Counter" }).ClickAsync();

        // Expects page to have a heading with the name of Installation.
        await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Counter" })).ToBeVisibleAsync();
    }


    [Test]
    public async Task Menu()
    {
        await Page.GotoAsync("http://localhost:5000/");

        // Click the get started link.
        var menuButton = Page.GetByText("Home");
        var menuButton2 = Page.GetByText("Counter");
        var menuButton23 = Page.GetByText("Weather");


        // Expects page to have a heading with the name of Installation.
        await Expect(menuButton).ToBeVisibleAsync();
        await Expect(menuButton2).ToBeVisibleAsync();
        await Expect(menuButton23).ToBeVisibleAsync();
    }

    [Test]
    public async Task ClickCounter()
    {
        await Page.GotoAsync("http://localhost:5000/");

        // Click the get started link.
        await Page.GetByText("Counter").ClickAsync();

        await Page.GotoAsync("http://localhost:5000/counter");


        await Page.GetByRole(AriaRole.Button, new() { Name = "Click me" }).ClickAsync();
        await Expect(Page.GetByText("Current count: 1")).ToBeVisibleAsync();
    }

    [Test]
    public async Task ClickWeather()
    {
        await Page.GotoAsync("http://localhost:5000/");

        // Click the get started link.
        await Page.GetByText("Weather").ClickAsync();

        await Page.GotoAsync("http://localhost:5000/weather");

        await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Weather" })).ToBeVisibleAsync();



    }
}
