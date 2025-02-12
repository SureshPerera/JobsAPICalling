var baseAddress = "https://jobicy.com/api/v2/";
var requistUri = "remote-jobs?count=20&geo=usa&industry=marketing&tag=seo";

IApiDataReader apiDataReader = new ApiDataReader();
var json = await apiDataReader.Read(baseAddress, requistUri);


Console.ReadLine();
public interface IApiDataReader
{
    public Task<string>Read(string baseAddress,string requistUri);
}
public class ApiDataReader : IApiDataReader
{
    public async Task<string> Read(string baseAddress, string requistUri)
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(baseAddress);
        HttpResponseMessage responce = await client.GetAsync(requistUri);
        responce.EnsureSuccessStatusCode();

        var json = await responce.Content.ReadAsStringAsync();
        return json;
    }
}