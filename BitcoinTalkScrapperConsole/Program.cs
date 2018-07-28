using BitcoinTalkScrapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinTalkScrapperConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstArgument = args.Any()?args.First().ToLower():String.Empty;
            Uri uriResult;
            bool validUrlArgument = Uri.TryCreate(firstArgument, UriKind.Absolute, out uriResult)
                          && (uriResult.Scheme == Uri.UriSchemeHttps);
            if (firstArgument.Equals("-h") || firstArgument.Equals("/h") || String.IsNullOrEmpty(firstArgument))
            {
                Console.WriteLine("Additional Usage: BitcoinTalkScrapperConsole.exe  https://bitcointalk.org/index.php?topic=#####");
                Console.WriteLine("Enter BitcoinTalk Page url to scrappe: ");
                MainAsync().Wait();
            }
            else if(validUrlArgument)
            {
                MainAsync(firstArgument).Wait();
            }
        }

        public static async Task MainAsync(String url = "")
        {
            url = String.IsNullOrEmpty(url)?Console.ReadLine():url; 
            BitcoinTalkTopicScrapper BtcTalkParser = new BitcoinTalkTopicScrapper();
            BitcoinTalkPage page = await BtcTalkParser.ScrappeTopic(url);
            ExportToJSON(page);
            Console.WriteLine("Export completed!");
            Console.ReadLine();
        }

        private static void ExportToJSON(BitcoinTalkPage btcPage, String fileName = "")
        {
            try
            {
                string rawJson = JsonConvert.SerializeObject(btcPage, Formatting.Indented);
                if (!String.IsNullOrEmpty(fileName) && File.Exists(fileName) && fileName.ToLower().EndsWith(".json"))
                {
                    File.WriteAllText(fileName, rawJson);
                }
                else
                {
                    fileName= AppDomain.CurrentDomain.BaseDirectory + "\\export_"+DateTime.Now.ToString("ddMMMyyyy_hhmmss")+".json";
                    File.WriteAllText(fileName, rawJson);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nUnable to write json export file, {0}!\n", fileName);
            }
        }
    }
}
