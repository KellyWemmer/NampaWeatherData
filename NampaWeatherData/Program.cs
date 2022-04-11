// See https://aka.ms/new-console-template for more informationvar client = new HttpClient();
var client = new HttpClient();
string apiKey = File.ReadAllText("./apikey.txt");
var request = new HttpRequestMessage
{
	Method = HttpMethod.Get,
	RequestUri = new Uri("https://community-open-weather-map.p.rapidapi.com/forecast?q=nampa%2Cus"),
	Headers =
	{
		{ "X-RapidAPI-Host", "community-open-weather-map.p.rapidapi.com" },
		{ "X-RapidAPI-Key", apiKey },
	},
};
using (var response = await client.SendAsync(request))
{
	response.EnsureSuccessStatusCode();
	var body = await response.Content.ReadAsStringAsync();
	Console.WriteLine(body);
}
