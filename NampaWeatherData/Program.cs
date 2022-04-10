// See https://aka.ms/new-console-template for more informationvar client = new HttpClient();
var client = new HttpClient();
var request = new HttpRequestMessage
{
	Method = HttpMethod.Get,
	RequestUri = new Uri("https://community-open-weather-map.p.rapidapi.com/forecast?q=nampa%2Cus"),
	Headers =
	{
		{ "X-RapidAPI-Host", "community-open-weather-map.p.rapidapi.com" },
		{ "X-RapidAPI-Key", "3ab517f604mshea3b863b9ef1a4bp199389jsnc2b5b70ba2b6" },
	},
};
using (var response = await client.SendAsync(request))
{
	response.EnsureSuccessStatusCode();
	var body = await response.Content.ReadAsStringAsync();
	Console.WriteLine(body);
}
