using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Furniture_Store.Model;

namespace Furniture_Store.Services
{
    public class PriceClient
    {
        private HttpClient client = new HttpClient();
       
        public async Task<Price> GetPriceAsync(string url)
        {
            Price price = null;
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                price = await response.Content.ReadFromJsonAsync<Price>();
            }
            return price;
        }



    }
}
