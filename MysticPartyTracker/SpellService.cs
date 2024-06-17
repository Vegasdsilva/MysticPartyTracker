using MysticPartyTracker.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker
{
    public interface ISpellService
    {
        Task<List<Result>> GetSpellAsync();
    }

    public class SpellService : ISpellService
    {
        private readonly HttpClient _httpClient;

        public SpellService(HttpClient httpclient)
        {
            _httpClient = httpclient;
        }

        public async Task<List<Result>> GetSpellAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<Response>("https://www.dnd5eapi.co/api/spells");
           
            return response?.Results ?? new List<Result>();
        }
    }
}
