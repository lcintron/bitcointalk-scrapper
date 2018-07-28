using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinTalkScrapper
{
    public class BitcoinTalkPage
    {
        public String Url { get; set; }
        public String Topic { get; set; }
        public String CurrentPage { get; set; }
        public String TotalPages { get; set; }

        public List<BitcoinTalkPost> Posts{get;set;}
    }
}
