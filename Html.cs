/*
Author: Kevin Lu
File: Html.cs
Purpose: Selecting the html code from url.
Modification: N/A
*/

using System;
using System.Net.Http;    // Allows client();
using HtmlAgilityPack;    // Html web scraping package/library.
using System.Linq;

namespace SlickDeals_Scraping
{
    public class Html
    {
        public void loadUrl(string url)
        {
            var htmlClient = new HttpClient();
            var html = htmlClient.GetStringAsync(url);

            Console.WriteLine(html.Result);
        }
        public void websiteURL(string url)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(url);

            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("ul");

            foreach (var node in htmlNodes)
            {
                Console.WriteLine(node.InnerHtml);
            }
        }
    }
}