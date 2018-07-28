using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebParser;
namespace BitcoinTalkScrapper
{
    public class BitcoinTalkTopicScrapper: WebRequestor
    {
        public BitcoinTalkTopicScrapper()
        {

        }

        public async Task<BitcoinTalkPage> ScrappePage(String url)
        {
            BitcoinTalkPage page = new BitcoinTalkPage();

            if (url.Contains("bitcointalk.org/index.php"))
            {
                IDocument pageDoc = await this.GetWeb(url);
                page.Url = url;
                page.Topic = pageDoc.QuerySelector("title").TextContent;
                page.CurrentPage = pageDoc.QuerySelectorAll("td.middletext b").Where(n => !n.TextContent.Equals(" ... ")).FirstOrDefault().TextContent;
                var pageNodes = pageDoc.QuerySelectorAll("a.navPages");
                page.TotalPages = pageNodes.ElementAt(pageNodes.Count()-2).TextContent;
                page.Posts = new List<BitcoinTalkPost>();
                var postElements = pageDoc.QuerySelectorAll("div.post").Where(n => !n.HasAttribute("style"));
                foreach(var postElement in postElements)
                {
                    BitcoinTalkPost post = new BitcoinTalkPost();
                    post.Topic = page.Topic;
                    post.Content = postElement.InnerHtml;
                    var postDate = postElement.ParentElement.QuerySelector("div.smalltext");
                    post.DatePosted = postDate.TextContent;

                    if (post.Content.Equals(post.DatePosted))
                        continue;

                    BitcoinTalkAuthor author = new BitcoinTalkAuthor();

                    author.Name = postElement.ParentElement.ParentElement.FirstElementChild.QuerySelectorAll("a")
                        .Where(a => a.HasAttribute("title") && a.GetAttribute("title").ToLower().Contains("view the profile")).First().TextContent;

                    String authordetailNode = postElement.ParentElement.ParentElement.FirstElementChild.QuerySelectorAll("div.smalltext").First().TextContent;
                    var authorDetails = authordetailNode.Replace("\t", "").Split(new String[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    author.MemberType = authorDetails.First();
                    author.Activity = authorDetails.Last().Split(new String[] { ":" }, StringSplitOptions.RemoveEmptyEntries).Last().Trim();
                    post.Author = author;
                    page.Posts.Add(post);
                }
            }
            return page;
        }


        public async Task<BitcoinTalkPage> ScrappeTopic(String url)
        {
            BitcoinTalkPage page = new BitcoinTalkPage();

            if (url.Contains("bitcointalk.org/index.php") && url.EndsWith(".0"))
            {
                page = await this.ScrappePage(url);
                int lastPageId = (Int32.Parse(page.TotalPages.Trim())*20)-20;
                int i = 20;
                String tempUrl ="";
                while (i <= lastPageId)
                {
                    try
                    {
                        BitcoinTalkPage topicPage;
                        tempUrl = url.Replace(".0", "." + i);
                        try
                        {
                            topicPage = await this.ScrappePage(tempUrl);
                        }
                        catch
                        {
                            topicPage = await this.ScrappePage(tempUrl);
                        }
                        page.Posts.AddRange(topicPage.Posts);
                        i += 20;
                    }
                    catch(Exception )
                    {
                        return page;
                    }
                }
            }
            return page;
        }
    }
}
