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
    public async Task TitleVisible()
    {
        await Page.GotoAsync("http://localhost:5000/");

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync("Home");
    }

    [Test]
    public async Task RedirectWeather()
    {
        await Page.GotoAsync("http://localhost:5000/");

        // Click the get started link.
        await Page.GetByRole(AriaRole.Link, new() { Name = "Counter" }).ClickAsync();

        // Expects page to have a heading with the name of Installation.
        await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Counter" })).ToBeVisibleAsync();
    }


    [Test]
    public async Task MenuVisible()
    {
        await Page.GotoAsync("http://localhost:5000/");

        // Click the get started link.
        var menuButton = Page.GetByText("Home");
        var menuButton2 = Page.GetByText("Counter");
        var menuButton23 = Page.GetByText("Weather");
        var menuButton3 = Page.GetByText("People");


        // Expects page to have a heading with the name of Installation.
        await Expect(menuButton).ToBeVisibleAsync();
        await Expect(menuButton2).ToBeVisibleAsync();
        await Expect(menuButton23).ToBeVisibleAsync();
        await Expect(menuButton3).ToBeVisibleAsync();
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

    [Test]
    public async Task FormPeople()
    {
        await Page.GotoAsync("http://localhost:5000/");

        // Click the get started link.
        await Page.GetByText("People").ClickAsync();

        await Page.GotoAsync("http://localhost:5000/people");

        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).IsVisibleAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Email" }).IsVisibleAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Sublimit" }).IsVisibleAsync();
    }
}
