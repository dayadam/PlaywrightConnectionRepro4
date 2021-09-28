using System;
using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightDemo5
{
    class Program
    {
        public static async Task Main()
        {
            var newPage = await GetPageAsync();
            await newPage.GotoAsync("https://playwright.dev/");
            var locator = newPage.Locator("//div");
            var locatorElm2 = locator.Nth(0).Locator("//div").Nth(0);
            var locatorHTML = await locatorElm2.InnerHTMLAsync();
        }

        public static async Task<IPage> GetPageAsync()
        {
            var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            return await browser.NewPageAsync();
        }
    }
}
