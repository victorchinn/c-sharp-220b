using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ThumbsUp
{
    public class CatService
    {
        private const string appId = "ba13addf5aea5b7a6ecd077819fc3cf0";

        public CatModel GetCat()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/");

            var result = client.GetAsync(string.Format("weather?appId={0}&q={1}", appId, "seattle")).Result;

            var json = result.Content.ReadAsStringAsync().Result;

            var weatherModel = JsonConvert.DeserializeObject<CatModel>(json);

            return weatherModel;
        }
    }
}
