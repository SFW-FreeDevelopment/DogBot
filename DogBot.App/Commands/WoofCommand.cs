using System.Threading.Tasks;
using Discord.Commands;

namespace DogBot.App.Commands
{
    public class WoofCommand : CommandBase
    {
        [Command("woof")]
        public async Task HandleCommandAsync()
        {
            await ReplyAsync("Woof woof!");
        }
    }
}