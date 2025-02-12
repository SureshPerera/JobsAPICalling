using System.Text.Json;

var baseAddress = "https://jobicy.com/api/v2/";
var requistUri = "remote-jobs?count=20&geo=usa&industry=marketing&tag=seo";

Console.WriteLine("\tDetail of List of remote jobs !! (API NAME = Jobicy)\n");
IApiDataReader apiDataReader = new ApiDataReader();
var json = await apiDataReader.Read(baseAddress, requistUri);

var root = JsonSerializer.Deserialize<Root>(json);

foreach (var item in root.jobs)
{
    Console.WriteLine($"job tital : {item.jobTitle},\njob type : {item.jobType.First()}, \njob sallary : {item.salaryCurrency}");
    Console.WriteLine();
}

Console.ReadLine();

