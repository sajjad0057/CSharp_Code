
using CsvHelper;
using CsvHelper.Configuration;
using Practice_ParseCSV;
using System.Globalization;

var csvText = "Name,Age,Location,Email\n" +
    "John,30,New York,john@email.com\n" +
    "Alice,25,Los Angeles,alice@email.com\n" +
    "Bob,35,Chicago,bob@email.com\n" +
    "Eve,28,San Francisco,eve@email.com\n" +
    "Charlie,40,Miami,charlie@email.com\n";

var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    HasHeaderRecord = true,  // CSV has a header row
    Delimiter = ","
};


using (var reader = new StringReader(csvText))
{
    using (var csv = new CsvReader(reader, csvConfig))
    {
        // Read the records from CSV into a list of objects.
        var records = csv.GetRecords<Record>().ToList();

        // Serialize the list of objects to JSON.
        var json = Newtonsoft.Json.JsonConvert.SerializeObject(records, Newtonsoft.Json.Formatting.Indented);

        Console.WriteLine(json);
    }
}
