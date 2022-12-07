using HtmlAgilityPack;

Console.WriteLine("Hello, World!");


HtmlWeb web = new HtmlWeb();

HtmlDocument document = web.Load("https://www.dse.com.bd/latest_share_price_scroll_l.php");

//var nodes = document.DocumentNode.SelectNodes("//tr/td").Select(x => x.InnerText).ToArray();

var table = document.DocumentNode.SelectNodes("//div[@class='table-responsive inner-scroll']/table/tbody/tr/td");

foreach (var row in table)
{
    Console.WriteLine($"{row.InnerText.Trim()}");
}

var table2 = document.DocumentNode.SelectNodes("//div[@class='table-responsive inner-scroll']/table/tr/td");

foreach(var x in table2)
{
    Console.WriteLine($"{x.InnerText.Trim()}");
}

Console.WriteLine();



