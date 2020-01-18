using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontBlazor.Data
{
    public class VoteService
    {

        public List<Vote> Votes { get; set; }

        public VoteService()
        {
            Votes = new List<Vote>();
        }
        public async Task<List<Vote>> GetVotes()
          {
            var _client = new HttpClient();

            Votes = await _client.GetJsonAsync<List<Vote>>("http://localhost:52349/api/Votes");
            return await Task.FromResult(Votes);
        }
        public async void AddVote(Vote vote)
        {
            var _client = new HttpClient();

            await _client.PostJsonAsync("http://localhost:52349/api/Votes", vote);
        }
    }
}
