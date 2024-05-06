using System.Globalization;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

var csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture);
using var reader = new StreamReader("AnsiWithUmlaut.csv", Encoding.Latin1);
using var csv = new CsvReader(reader, csvConfiguration);
var records = csv.GetRecords<CsvDto>();
Console.ReadLine();

internal class CsvDto
{
    [Name("id")] public string Id { get; set; }

    [Name("name")] public string Name { get; set; }

    [Name("währung")] public string Currency { get; set; }
}