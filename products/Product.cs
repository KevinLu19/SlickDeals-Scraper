/*
Author: Kevin Lu
File: Product.cs
Purpose: Class for the products that are scraped.
Modification: N/A
*/

namespace SlickDeals_Scraping.products
{
    public class Product
    {
        public string itemName { get; set; }
        public decimal itemPrice { get; set; }
        public string itemURL { get; set; }
        public string itemDescription { get; set; }
    }
}