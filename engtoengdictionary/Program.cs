using Newtonsoft.Json;

Console.WriteLine("Write the word that you are curious about the meaning in English?");
string word = Console.ReadLine();
string url = $"https://api.dictionaryapi.dev/api/v2/entries/en/{word}";
HttpClient client = new HttpClient();
HttpResponseMessage answer = await client.GetAsync(url);
string json = await answer.Content.ReadAsStringAsync();
dynamic data = JsonConvert.DeserializeObject(json);
Console.WriteLine(data[0].meanings[0].definitions[0].definition);

