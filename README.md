# Bitcoin Talk Forum Scrapper

![Buildkite pass](https://img.shields.io/buildkite/3826789cf8890b426057e6fe1c4e683bdf04fa24d498885489/master.svg)
![GitHub license](https://img.shields.io/github/license/mashape/apistatus.svg)

Exports a whole topic to JSON! Pass the topic url as the argument or enter it in the console. Application outputs all posts and author info in json format.

## Features
- Library to scrappe Bitcointalk.org pages (or whole topics)
- Export scrapped content to json
 
## Build
 - Language: C#
 - Tested on .Net Framework 4.6.1
 
## Run
- Command Line Example:
  > .\BitcoinTalkScrapperConsole.exe https://bitcointalk.org/index.php?topic=3789535.0

- Double click .exe and entered the bitcointalk.org topic url to export.

## Example Output
'''json
{
  "Url": "https://bitcointalk.org/index.php?topic=4554177.0",
  "Topic": "How Can/Do You Store Files on a Blockchain?",
  "CurrentPage": "1",
  "TotalPages": "2",
  "Posts": [
    {
      "Topic": "How Can/Do You Store Files on a Blockchain?",
      "Author": {
        "Name": "Maveth13",
        "MemberType": "Full Member",
        "Activity": "111"
      },
      "DatePosted": "June 27, 2018, 02:02:38 PM",
      "Content": "We know blockchain is not only limited to cryptocurrencies. But how exactly do you store files, say a one page pdf, in a blockchain? Especially without using any third-party services like IPFS."
    },
    {
      "Topic": "How Can/Do You Store Files on a Blockchain?",
      "Author": {
        "Name": "goddog",
        "MemberType": "Member",
        "Activity": "8426 2618 9F5F C7BF 22BD  E814 763A 57A1 AA19 E681"
      },
      "DatePosted": "June 27, 2018, 02:25:24 PM",
      "Content": "<div class=\"quoteheader\"><a href=\"https://bitcointalk.org/index.php?topic=4554177.msg41016260#msg41016260\">Quote from: Maveth13 on June 27, 2018, 02:02:38 PM</a></div><div class=\"quote\">We know blockchain is not only limited to cryptocurrencies. But how exactly do you store files, say a one page pdf, in a blockchain? Especially without using any third-party services like IPFS.<br></div>Are you asking about how to abuse the blockchain? lol. <br>You should not!"
    },
    {
      "Topic": "How Can/Do You Store Files on a Blockchain?",
      "Author": {
        "Name": "Maveth13",
        "MemberType": "Full Member",
        "Activity": "111"
      },
      "DatePosted": "June 27, 2018, 03:13:31 PM",
      "Content": "<div class=\"quoteheader\"><a href=\"https://bitcointalk.org/index.php?topic=4554177.msg41017641#msg41017641\">Quote from: goddog on June 27, 2018, 02:25:24 PM</a></div><div class=\"quote\"><div class=\"quoteheader\"><a href=\"https://bitcointalk.org/index.php?topic=4554177.msg41016260#msg41016260\">Quote from: Maveth13 on June 27, 2018, 02:02:38 PM</a></div><div class=\"quote\">We know blockchain is not only limited to cryptocurrencies. But how exactly do you store files, say a one page pdf, in a blockchain? Especially without using any third-party services like IPFS.<br></div>Are you asking about how to abuse the blockchain? lol. <br>You should not!<br></div><br>Abuse? Clearly you should read more. File storage is one of the best usecase for blockchain, and there's already a lot of sites/services that provides it."
    },
    {
      "Topic": "How Can/Do You Store Files on a Blockchain?",
      "Author": {
        "Name": "goddog",
        "MemberType": "Member",
        "Activity": "8426 2618 9F5F C7BF 22BD  E814 763A 57A1 AA19 E681"
      },
      "DatePosted": "June 27, 2018, 03:26:16 PM",
      "Content": "<div class=\"quoteheader\"><a href=\"https://bitcointalk.org/index.php?topic=4554177.msg41020591#msg41020591\">Quote from: Maveth13 on June 27, 2018, 03:13:31 PM</a></div><div class=\"quote\"><div class=\"quoteheader\"><a href=\"https://bitcointalk.org/index.php?topic=4554177.msg41017641#msg41017641\">Quote from: goddog on June 27, 2018, 02:25:24 PM</a></div><div class=\"quote\"><div class=\"quoteheader\"><a href=\"https://bitcointalk.org/index.php?topic=4554177.msg41016260#msg41016260\">Quote from: Maveth13 on June 27, 2018, 02:02:38 PM</a></div><div class=\"quote\">We know blockchain is not only limited to cryptocurrencies. But how exactly do you store files, say a one page pdf, in a blockchain? Especially without using any third-party services like IPFS.<br></div>Are you asking about how to abuse the blockchain? lol. <br>You should not!<br></div><br>Abuse? Clearly you should read more. File storage is one of the best usecase for blockchain, and there's already a lot of sites/services that provides it.<br></div><b>Clearly you should read more</b> there are better ways to share files than spamming the blockchain.<br>the blockchain is very inefficent for these stuff. Of course there are a lot of scammers trying to sell the blockchain to steal some money from people like you.<br>"
    },
  ]
}
'''

## Dependencies
- AngleSharp by AngleSharp (NuGet)
- CommandLineParser20 by Giacomo Stelluti Scala(NuGet)
- Jint by Sebastien Ros (NuGet)
- Newtonsoft.Json by James Newton-King (NuGet)

## License
Published under MIT license.

MIT License

Copyright (c) 2018 Luis Cintron

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
