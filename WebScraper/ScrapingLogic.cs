using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Xml;

namespace WebScraper
{
    public class ScrapingLogic
    {
        public List<string> extractNodes(string url) {
            // List will contain the nodes
            List<string> extracted_nodes = new List<string>();

            // an object DOM to crawl and extract data from web pages
            HtmlWeb web = new HtmlWeb();

            // the DOM loadds a web pages from a url and stores it in variable
            var HTML_doc = web.Load(url);

            // specify what nodes from a web page we want to fetch data from
            var nodes = HTML_doc.DocumentNode.SelectNodes("/html/body");
  

            // Convert each element in nodes into string
            foreach (var node in nodes)
            {
                extracted_nodes.Add(node.InnerHtml);
            }

            return extracted_nodes;
        } 
    }
}
