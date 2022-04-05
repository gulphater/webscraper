using System;
using System.Collections.Generic;
using System.IO; 

namespace WebScraper
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // create a List of string type to store the returned data from scraper object
            List<string> fetched_data = new List<string>();


            // this is the object from the scraper class we have created
            ScrapingLogic scraper = new ScrapingLogic();

            // a variable to store the url of a web page to be scraped
            string url = "https://www.usf.edu/engineering/"; 

            // use the method extractNodes() to return the list of nodes' innerHTML
            fetched_data = scraper.extractNodes(url);

            // Print the data in the console
            Console.WriteLine(fetched_data);

            // Use your path from root to create a file
            File.WriteAllLines("/home/shoh/kayf/WebScraper/RESULTS_2.txt", fetched_data); 
        }
    }
}
