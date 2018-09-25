using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Models.Decoration;

namespace Repositories.Decoration
{

    public class DecorationsRepository : Models.Decoration.IDecorationsRepository
    {
        private string baseUrl;
        static string decorationApiPath = "/decorations";
        public DecorationsRepository(string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(baseUrl)) { throw new ArgumentNullException(nameof(baseUrl)); }
            this.baseUrl = baseUrl;
        }

        public async Task<IEnumerable<Models.Decoration.Decoration>> GetDecorations()
        {
            using (HttpClient client = new HttpClient() { BaseAddress = new System.Uri(baseUrl) })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync(decorationApiPath);
                if (result.IsSuccessStatusCode)
                {
                    var data = await result.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Models.Decoration.Decoration>>(data);
                }
                else
                {
                    throw new System.Exception(result.ReasonPhrase);
                }

            }
        }
    }
}
