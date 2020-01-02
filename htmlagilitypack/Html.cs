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
using System.Web;

using SlickDeals_Scraping.products;

namespace SlickDeals_Scraping.html
{
    public class Html
    {
        public void websiteURL(string url)
        {
            var web = new HtmlWeb();
            var doc = web.Load(url);
            
            //int data_module_item = 1;

            var nodes = doc.DocumentNode.SelectNodes("//div/div/div/div/ul/li");
    
            foreach (var item in nodes)
            {
                // while (item.Attributes[data_module_item].Value != null)
                // {
                //     // var newNode = doc.DocumentNode.SelectNodes("div/div/div/div/div/div");
                //     Console.WriteLine(item.Attributes["class"].Value);
                // }

                Console.WriteLine(item.Attributes["class"].Value);
            }
        }
    }
}