using System;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;


namespace WebParser
{
    public class WebRequestor
    {
        public WebRequestor()
        {

        }
        protected virtual async Task<IDocument> GetWeb(String Uri)
        {
            try
            {
                var config = Configuration.Default.WithDefaultLoader().WithCss().WithCookies().WithJavaScript();

                // We create a new context
                var context = BrowsingContext.New(config);
                IDocument response = await context.OpenAsync(Uri);
                return response;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
