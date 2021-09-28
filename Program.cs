using System;
using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightDemo5
{
    class Program
    {
        public static async Task Main()
        {
            //using var playwright = await Playwright.CreateAsync();
            //await using var browser = await playwright.Chromium.LaunchAsync();
            //var page = await browser.NewPageAsync();
            var newPage = await GetPageAsync();
            await newPage.GotoAsync("https://playwright.dev/");
            var locator = newPage.Locator("//div");
            Console.Write(locator);
            var locatorElm2 = locator.Nth(0).Locator("//div").Nth(0);
            var locatorHTML = await locatorElm2.InnerHTMLAsync();
            //var locatorHTML1 = await locatorElm.InnerHTMLAsync();
            //var locatorHTML2 = await locatorElm.InnerHTMLAsync();
            //var locatorHTML3 = await locatorElm.InnerHTMLAsync();
            //var locatorHTML4 = await locatorElm.InnerHTMLAsync();
            //var locatorHTML5 = await locatorElm.InnerHTMLAsync();
            //var locatorHTML6 = await locatorElm.InnerHTMLAsync();
            //string locatorSelectorString = locatorElm.ToString();
            //string selectorString = locatorSelectorString.Split("Locator@")[1];
            //var locatorAgain = page.Locator("xpath=" + selectorString);
            //await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });
        }

        public static async Task<IPage> GetPageAsync()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            return await browser.NewPageAsync();
            //return await page.GotoAsync("https://www.scorpionbay.com/en-US/howtoorder/htmlcontent-1717");
        }

        //public static ILocator GetLocator(string xpath)
        //{

        //}
    }
}
