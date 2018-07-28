using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinTalkScrapper
{
    public class BitcoinTalkPost
    {
        public String Topic { get; set; }
        public BitcoinTalkAuthor Author {get;set;}
        public String DatePosted { get; set; }

        public String Content { get; set; }

    }
}
