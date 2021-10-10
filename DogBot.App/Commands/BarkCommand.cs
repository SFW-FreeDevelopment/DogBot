using System.Threading.Tasks;
using Discord.Commands;

namespace DogBot.App.Commands
{
    public class BarkCommand : CommandBase
    {
        [Command("bark")]
        public async Task HandleCommandAsync()
        {
            await ReplyAsync("Bark bark!");
        }
    }
}