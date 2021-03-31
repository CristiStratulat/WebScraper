using System;
using OpenQA.Selenium.Chrome;
using Discord.Webhook;
using System.Text;
using System.Collections.Generic;

namespace WebScraper
{
    class Program
    {
        private static string Modify(string x)
        {
            var builder = new StringBuilder();
            int count = 0;
            foreach (char c in x)
            {
                builder.Append(c);
                count++;
                if (count == x.Length - 6)
                {
                    builder.Append(',');
                }

            }
            return builder.ToString();
        }
        static void Main(string[] args)
        {
            
            DiscordWebhookClient ScrappyBot = new DiscordWebhookClient("https://discord.com/api/webhooks/826908590991474710/Q2wKMWry407JmnUyrT1wqZUkH7Enk1OS_bpnzoNqNB6nikime1CyRcEMhetPDWg_W_5x");
            using (var driver = new ChromeDriver())
                {
                    driver.Navigate().GoToUrl("https://www.emag.ro/tablete/brand/apple/filter/ipad-f3557,ipad-air-4-v8668/conectivitate-f8661,fara-sim-v-7002211/capacitate-stocare-f8881,256-gb-v-4670700/c?ref=lst_quick_8661_-7002211");
                
                    var itemName = driver.FindElementsByClassName("product-title-zone");
                    var priceValue = driver.FindElementsByClassName("product-new-price");

                    
                List<String> itemNames = new List<String>(priceValue.Count);
                List<String> prices = new List<String>(priceValue.Count);
                for (int i = 0; i < priceValue.Count; i++)
                    {
                    itemNames.Add(Modify(priceValue[i].GetAttribute("innerText").ToString()));
                    prices.Add(itemName[i].GetAttribute("innerText").ToString());
                    
                    }
                    ScrappyBot.SendMessageAsync();
            }
            

           
        }

        
    }
}
