using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Models.Armor;
using Models.Armor.Results;

namespace Repositories.Armor
{

    public class ArmorRepository : Models.Armor.IArmorRepository
    {
        private string baseUrl;
        static string armorApiPath = "/armor";
        static string armorSetApiPath = "/armor/sets";
        public ArmorRepository(string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(baseUrl)) { throw new ArgumentNullException(nameof(baseUrl)); }
            this.baseUrl = baseUrl;
        }
        //$"https://mhw-db.com"
        private async Task<IEnumerable<Models.Armor.Armor>> GetArmorsAsync()
        {
            using (HttpClient client = new HttpClient() { BaseAddress = new System.Uri(baseUrl) })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync(armorApiPath);
                if (result.IsSuccessStatusCode)
                {
                    var data = await result.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Models.Armor.Armor>>(data);
                }
                else
                {
                    throw new System.Exception(result.ReasonPhrase);
                }

            }
        }

        private async Task<IEnumerable<ArmorSet>> GetArmorSetsAsync()
        {
            using (HttpClient client = new HttpClient() { BaseAddress = new System.Uri(baseUrl) })
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync(armorSetApiPath);
                if (result.IsSuccessStatusCode)
                {
                    var data = await result.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Models.Armor.ArmorSet>>(data);
                }
                else
                {
                    throw new System.Exception(result.ReasonPhrase);
                }

            }
        }

        public async Task<ArmorsResult> GetArmorsResultAsync()
        {
            var armors = await GetArmorsAsync();
            var armorSets = await GetArmorSetsAsync();

            var armorSetsResult = from set in armorSets select new ArmorSetResult {
                id = set.id, name = set.name, rank = set.setRank, setBonus = set.bonus,
                associatedArmorIds = set.pieces.Select(s => s.id) };
            ArmorsResult result = new ArmorsResult()
            {
                armors = armors,
                armorSets = armorSetsResult
            };

            return result;
        }
    }
}
