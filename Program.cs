/*
Author: Kevin Lu
File: Program.cs
Purpose: Web scraping slickdeals website.
Modification: N/A
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
            var url = "https://slickdeals.net/";

            Html websiteHtml = new Html();
            websiteHtml.loadUrl(url);
        }
    }
}