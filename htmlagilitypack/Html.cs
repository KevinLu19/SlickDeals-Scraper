/*
Author: Kevin Lu
File: Html.cs
Purpose: Selecting the html code from url.
Modification: - Added a way to print out entire front page list from slickdeals.
*/

using System;
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
            // web loads the url provided.
            var web = new HtmlWeb();
            var htmlDoc = new HtmlDocument();
            htmlDoc = web.Load(url);

            // Selects desire HTML to parse.
            var htmlUL = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='gridCategory removeHidden']");
            
            HtmlNodeCollection childNodes = htmlUL.ChildNodes;
            
            foreach (var node in childNodes)
            {
                if (node.NodeType == HtmlNodeType.Element)
                {
                    Console.WriteLine(node.OuterHtml);
                }
            }		
        }
    }
}