namespace launcher.c6.Facade;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class WeatherInfo
{
    public required string Temperature { get; set; }
}
public class WeatherFacade
{
    public static async Task<WeatherInfo> GetWeather(string city)
        {
            //Define your base url
            var baseUrl = $"https://wttr.in/{city}?format=j1";
            //Have your api call in try/catch block.
            try { 
                //Now we will have our using directives which would have a HttpClient 
                using (HttpClient client = new HttpClient())
                {
                    //Now get your response from the client from get request to baseurl.
                    //Use the await keyword since the get request is asynchronous, and want it run before next asychronous operation.
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        //Now we will retrieve content from our response, which would be HttpContent, retrieve from the response Content property.
                        using (HttpContent content = res.Content)
                        {
                            //Retrieve the data from the content of the response, have the await keyword since it is asynchronous.
                            string data = await content.ReadAsStringAsync();
                            //If the data is not null, parse the data to a C# object, then create a new instance of PokeItem.
                            if (!string.IsNullOrEmpty(data))
                            {
                                //Parse your data into a object.
                                var dataObj = JObject.Parse(data);
                                
                                var temperature = dataObj["current_condition"]?[0]?["temp_C"]?.ToString() ?? "n/a";;
                                
                                return new WeatherInfo
                                {
                                    Temperature = temperature
                                };
                            }
                            else
                            {
                                //If data is null log it into console.
                                Console.WriteLine("Data is null!");
                                return new WeatherInfo { Temperature = "n/a" };
                            }
                        }
                    }
                }
                //Catch any exceptions and log it into the console.
            } catch(Exception exception) {
                Console.WriteLine(exception);
                return new WeatherInfo { Temperature = "n/a" };
            }
        }
}
