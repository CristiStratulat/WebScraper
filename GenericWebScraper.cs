using OpenQA.Selenium.Chrome;
using System.Text;

namespace WebScrapper
{
    public class GenericWebScraper
    {
        public GenericWebScraper()
        {

        }
        public static string WebScrap(string siteName, string URL, string XPathItem, string XPathPrice)
        {
            var builder = new StringBuilder();
            builder.Append(siteName + System.Environment.NewLine);
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl(URL);

            var itemNames = driver.FindElementsByXPath(XPathItem);
            var itemPrices = driver.FindElementsByXPath(XPathPrice);

            for(int i=0;i<itemNames.Count;i++)
            {
                if(siteName=="EMAG")
                {
                    builder.Append(Modify(itemPrices[i].GetAttribute("innerText").ToString()) + " " + itemNames[i].GetAttribute("innerText").ToString() + System.Environment.NewLine);
                }
                else
                    builder.Append(itemPrices[i].GetAttribute("innerText").ToString()+" "+itemNames[i].GetAttribute("innerText").ToString()+System.Environment.NewLine);
            }
            return builder.ToString();
        }
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

    }
}
