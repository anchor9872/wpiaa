namespace launcher.c6.Strategy;

public class PexelsStrategy : IImageSearchStrategy
{
    private const string ApiKey = Secrets.PixabayApiKey;

    public async Task Search(string query)
    {
        using (var client = new HttpClient())
        {
            try
            {
                client.DefaultRequestHeaders.Add("Authorization", ApiKey);
                    
                string url = $"https://api.pexels.com/v1/search?query={query}&per_page=3";
                    
                HttpResponseMessage response = await client.GetAsync(url);
                    
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Sukces! Podgląd odpowiedzi:");
                    Console.WriteLine(content.Substring(0, Math.Min(content.Length, 300)) + "...");
                }
                else
                {
                    Console.WriteLine($"Błąd HTTP: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd połączenia: {ex.Message}");
            }
        }
    }
}