using HtmlAgilityPack;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");


HtmlWeb web = new HtmlWeb();

HtmlDocument document = web.Load("https://www.dse.com.bd/latest_share_price_scroll_l.php");

//var nodes = document.DocumentNode.SelectNodes("//tr/td").Select(x => x.InnerText).ToArray();

var tables = document.DocumentNode.SelectNodes("//table//tr");

foreach (var node in tables)
{
    //var id = node.SelectSingleNode($"td[{2}]").InnerText;
    if (node.SelectSingleNode($"td[{2}]") != null)
    {
        var id = node.SelectSingleNode($"td[{2}]").InnerText;

        Console.WriteLine(id.Trim());

    }

    if (node.SelectSingleNode($"td[{3}]") != null)
    {
        var id = node.SelectSingleNode($"td[{3}]").InnerText;
        if (id.Length <= 10)
        {
            Console.WriteLine(id.Trim());
        }
    }
}




