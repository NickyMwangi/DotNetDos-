using HtmlAgilityPack;

public class WebScraper
{
    public static async Task Main(string[] args)
    {
        var url = "https://en.wikipedia.org/wiki/OpenAI";
        var httpClient = new HttpClient();
        var html = await httpClient.GetStringAsync(url);

        var htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(html);

        var div = htmlDoc.DocumentNode.Descendants("div")
            .Where(node => node.GetAttributeValue("class", "")
            .Contains("mw-parser-output")).ToList();

        div.ForEach(n =>
        {
            var paragraphs = n.Descendants("p").Where(r => !string.IsNullOrWhiteSpace(r.InnerText)).ToList();
            if (paragraphs.Count > 0)
            {
                paragraphs.ForEach(t =>
                {
                    Console.WriteLine(t.InnerText.Trim());
                });
            }
        });
    }

    /** ScrappingBee Package
     * To help scrap data from JS website and a website with Proxy that blocks web scrapping
     * Help to handle website errors
     */

    //Learnt this from TutorialEU
    // https://www.youtube.com/watch?v=5wCADuDnj7A
    // Learn how to WebScrap a procy se
}