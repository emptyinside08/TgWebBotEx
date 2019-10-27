using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot.Types;
using Telegram.Bot;
using System.Threading.Tasks;

namespace TgWebBot.Models
{
    public abstract class Command
    {
        public abstract string Name { get; }

        public abstract void Execute(Message message, TelegramBotClient clients);

        public bool Contains(string command)
        {
            return command.Contains(this.Name) && command.Contains(AppSettings.name);
        }

        internal static void Execute(Message message, Task<TelegramBotClient> client)
        {
            throw new NotImplementedException();
        }
    }
}