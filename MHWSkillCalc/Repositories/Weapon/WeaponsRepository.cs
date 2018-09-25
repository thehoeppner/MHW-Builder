using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Models.Weapon;

namespace Repositories.Weapon
{
    public class WeaponsRepository : Models.Weapon.IWeaponRepository
    {
        private string baseUrl;
        static string weaponApiPath = "/weapons";
        public WeaponsRepository(string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(baseUrl)) { throw new ArgumentNullException(nameof(baseUrl)); }
            this.baseUrl = baseUrl;
        }

        public async Task<IEnumerable<Models.Weapon.Weapon>> GetWeapons()
        {
            using (HttpClient client = new HttpClient() { BaseAddress = new System.Uri(baseUrl) })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync(weaponApiPath);
                if (result.IsSuccessStatusCode)
                {
                    var data = await result.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Models.Weapon.Weapon>>(data);
                }
                else
                {
                    throw new System.Exception(result.ReasonPhrase);
                }

            }
        }
    }
}
