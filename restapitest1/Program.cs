using Newtonsoft.Json;

namespace restapitest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https://swapi.dev/api/people/";
            HttpClient client = new HttpClient();

            HttpResponseMessage httpResponse = client.GetAsync(url).Result;

            string response = httpResponse.Content.ReadAsStringAsync().Result;

            Console.WriteLine(response);

            People swapi = JsonConvert.DeserializeObject<People>(response);
            
            Console.WriteLine(swapi);
            Console.ReadLine();
        }
    }
}