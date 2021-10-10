using Discord.Commands;

namespace DogBot.App.Commands
{
    public abstract class CommandBase : ModuleBase<SocketCommandContext>
    {
        protected string Mention => Context.Message.Author.Mention;
    }
}