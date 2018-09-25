using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Models.Item;

namespace Repositories.Item
{
    public class ItemsRepository : Models.Item.IItemsRepository
    {
        private string baseUrl;
        static string itemApiPath = "/items";
        public ItemsRepository(string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(baseUrl)) { throw new ArgumentNullException(nameof(baseUrl)); }
            this.baseUrl = baseUrl;
        }

        public async Task<IEnumerable<Models.Item.Item>> GetItems()
        {
            using (HttpClient client = new HttpClient() { BaseAddress = new System.Uri(baseUrl) })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync(itemApiPath);
                if (result.IsSuccessStatusCode)
                {
                    var data = await result.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Models.Item.Item>>(data);
                }
                else
                {
                    throw new System.Exception(result.ReasonPhrase);
                }

            }
        }
    }
}
