/*
Author: Kevin Lu
File: Program.cs
Purpose: Web scraping slickdeals website.
*/

using System;
using System.Net.Http;  // HttpClient();
using HtmlAgilityPack;  // Package - For parsing html data.
using System.Linq;      // Allows .Where()

namespace SlickDeals_Scraping
{
    class Program
    {
        static void Main(string[] args)
        {
            fetchHTML();
            
            Console.ReadLine();  
        }

        private static async void fetchHTML()
        {
            var url = "https://slickdeals.net/";

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var dealHtml = htmlDoc.DocumentNode.Descendants("ul")
            .Where(node => node.GetAttributeValue("id", "")
            .Equals("dealTiles gridDeals")).ToList();

            var dealParser = dealHtml[0].Descendants("li")
            .Where(node => node.GetAttributeValue("class", "")
            .Contains("fpGridBox grid ")).ToList();

            
            Console.WriteLine(dealHtml);
        }
    }
}