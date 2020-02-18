using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontBlazor.Data
{
    public class ExcuseService
    {

        public List<Excuse> Excuses { get; set; }

        public ExcuseService()
        {
            Excuses = new List<Excuse>();
        }
        public async Task<List<Excuse>> GetExcuses()
          {
            var _client = new HttpClient();

            Excuses = await _client.GetJsonAsync<List<Excuse>>("http://localhost:52349/api/Excuses");
            return await Task.FromResult(Excuses);
        }       
        public async Task<List<Excuse>> GetTopTen()
        {
            var _client = new HttpClient();

            Excuses = await _client.GetJsonAsync<List<Excuse>>("http://localhost:52349/api/GetTopTen");
            return await Task.FromResult(Excuses);
        }        
        public async Task<List<Excuse>> GetTopHitByMonth()
        {
            var _client = new HttpClient();

            Excuses = await _client.GetJsonAsync<List<Excuse>>("http://localhost:52349/api/TopHitByMonth");
            return await Task.FromResult(Excuses);
        }        
        public async Task<List<Excuse>> GetTopHitByYear()
        {
            var _client = new HttpClient();

            Excuses = await _client.GetJsonAsync<List<Excuse>>("http://localhost:52349/api/TopHitByYear");
            return await Task.FromResult(Excuses);
        }
        public async void AddExcuse(Excuse excuse)
        {
            var _client = new HttpClient();

            await _client.PostJsonAsync("http://localhost:52349/api/Excuses", excuse);
        }
    }
}
