using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Models.Charm;

namespace Repositories.Charm
{
    public class CharmsRepository : Models.Charm.ICharmsRepository
    {
        private string baseUrl;
        static string charmApiPath = "/charms";
        public CharmsRepository(string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(baseUrl)) { throw new ArgumentNullException(nameof(baseUrl)); }
            this.baseUrl = baseUrl;
        }

        public async Task<IEnumerable<Models.Charm.Charm>> GetCharms()
        {
            using (HttpClient client = new HttpClient() { BaseAddress = new System.Uri(baseUrl) })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync(charmApiPath);
                if (result.IsSuccessStatusCode)
                {
                    var data = await result.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Models.Charm.Charm>>(data);
                }
                else
                {
                    throw new System.Exception(result.ReasonPhrase);
                }

            }
        }
    }
}
