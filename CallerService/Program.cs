using System.Net.Http;

var client = new HttpClient();
var response = await client.GetStringAsync("http://helloservice:8080/");
Console.WriteLine($"Received: {response}");
