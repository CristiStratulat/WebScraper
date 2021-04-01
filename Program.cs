using System;
using OpenQA.Selenium.Chrome;
using Discord.Webhook;
using System.Text;
using WebScrapper;

namespace WebScraper
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var txt = new StringBuilder();
            string mediaGalaxy, emag, altex, flanco;
            DiscordWebhookClient ScrappyBot = new DiscordWebhookClient("https://discord.com/api/webhooks/826908590991474710/Q2wKMWry407JmnUyrT1wqZUkH7Enk1OS_bpnzoNqNB6nikime1CyRcEMhetPDWg_W_5x");
         
            mediaGalaxy = GenericWebScraper
                .WebScrap("MEDIA GALAXY",
                "https://mediagalaxy.ro/tablete/cpl/filtru/brand-3334/apple/capacitate-stocare-2967/256-gb/producator-procesor-2962/apple/dimensiune-ecran-inch-8660/10-5-11/conectivitate-3885/wi-fi/tip-procesor-2963/hexa-core/",
                "//*[@class='Product-list-center']",
                "//*[@class='Price-current']");
            txt.Append(mediaGalaxy);

            emag = GenericWebScraper.
                WebScrap("EMAG",
                "https://www.emag.ro/tablete/brand/apple/filter/ipad-f3557,ipad-air-4-v8668/conectivitate-f8661,fara-sim-v-7002211/capacitate-stocare-f8881,256-gb-v-4670700/c?ref=lst_quick_8661_-7002211",
                "//*[@class='product-title js-product-url']",
                "//*[@class='product-new-price']"
                );
            txt.Append(emag);
            
            altex = GenericWebScraper.
                WebScrap("ALTEX",
                "https://altex.ro/tablete/cpl/filtru/brand-3334/apple/conectivitate-3885/wi-fi/tip-procesor-2963/hexa-core/capacitate-stocare-2967/256-gb/",
                "//*[@class='Product-list-center']",
                "//*[@class='Price-int']");
            txt.Append(altex);
            
            flanco = GenericWebScraper.
                 WebScrap("FLANCO",
                 "https://www.flanco.ro/telefoane-tablete/tablete-si-accesorii/tablete-ios/filtre/conectivitate-tablete/fara_sim/model-procesor-telefoane/hexa_core/model-tableta/ipad_air/price/3500-.html",
                 "//*[@class='produs-title']",
                 "//*[@class='produs-price special-priceyso']");
            txt.Append(flanco);
            
        
           ScrappyBot.SendMessageAsync(txt.ToString());

        }

        
    }
}
