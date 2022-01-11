using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherPage.Data
{
    public class WeatherForecastService
    {
        
        public async Task<WeatherForecastModel> GetForecastAsync(string cityName)
        {
            HttpClient client = new HttpClient();
            // man
            
            var response = await client.GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={cityName}&lang=cz&appid=96a6ffa306c18c94f602100a9a1bdcee");
            string json = await response.Content.ReadAsStringAsync();
            WeatherForecastModel forecast = JsonConvert.DeserializeObject<WeatherForecastModel>(json);
            return forecast;
        }
    }
}
