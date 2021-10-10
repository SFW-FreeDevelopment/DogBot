using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discord.Commands;
using DogBot.App.Models;
using RestSharp;

namespace DogBot.App.Commands
{
    public class FactCommand : CommandBase
    {
        [Command("fact")]
        public async Task HandleCommandAsync()
        {
            var restClient = new RestClient();
            var request = new RestRequest("https://dog-facts-api.herokuapp.com/api/v1/resources/dogs?number=1");
            var response = await restClient.ExecuteAsync<List<FactResponse>>(request);

            if (response.Data == null || !response.Data.Any())
            {
                await ReplyAsync("No dog facts could be found at this time. Please try again later.");
            }
            else
            {
                await ReplyAsync(response.Data.First().Fact);   
            }
        }
    }
}