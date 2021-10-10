using System;
using System.Threading.Tasks;
using Discord.Commands;

namespace DogBot.App.Commands
{
    public class HelpCommand : CommandBase
    {
        [Command("help")]
        public async Task HandleCommandAsync()
        {
            await ReplyAsync($"**The following commands can be used:**{Environment.NewLine}" +
                             $"  • **ping** - Pings the Discord channel{Environment.NewLine}" +
                             $"  • **konami** - Displays the Konami code as emojis{Environment.NewLine}" +
                             $"  • **bark** - Barks in chat{Environment.NewLine}" +
                             $"  • **woof** - Woofs in chat{Environment.NewLine}" +
                             $"  • **fact** - Displays a random dog fact{Environment.NewLine}" +
                             $"  • **photo** - Displays a random dog photo");
        }
    }
}