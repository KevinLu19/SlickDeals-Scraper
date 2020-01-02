/*
Author: Kevin Lu
File: Program.cs
Purpose: Web scraping slickdeals website.
*/

using System;
using System.Net.Http;  // HttpClient();
using HtmlAgilityPack;  // Package - For parsing html data.
using System.Linq;      // Allows .Where()

using SlickDeals_Scraping.gmail;  // Enable gmail api code.
using SlickDeals_Scraping.html;
namespace SlickDeals_Scraping
{
    class Program
    {
        static void Main(string[] args)
        {
            const string url = "https://slickdeals.net/";
            
            Html html = new Html();
            html.websiteURL(url);
            

            // gmailApi gmail = new gmailApi();
            // gmail.gmailService();
        }
    }
}