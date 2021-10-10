using System.Threading.Tasks;
using Discord.Commands;
using DogBot.App.Models;
using RestSharp;

namespace DogBot.App.Commands
{
    public class PhotoCommand : CommandBase
    {
        [Command("photo")]
        public async Task HandleCommandAsync()
        {
            var restClient = new RestClient();
            var request = new RestRequest("https://random.dog/woof.json");
            var response = await restClient.ExecuteAsync<PhotoResponse>(request);

            if (response.Data == null || string.IsNullOrEmpty(response.Data.Url))
            {
                await ReplyAsync("No dog photos could be found at this time. Please try again later.");
            }
            else
            {
                await ReplyAsync(response.Data.Url);   
            }
        }
    }
}