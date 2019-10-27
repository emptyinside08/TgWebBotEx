using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TgWebBot.Models
{
    public class Commandth : Command
    {
        public override string Name => "hello";

        public override async void Execute(Message message, TelegramBotClient clients)
        {
            var chatID = message.Chat.Id;
            var messageId = message.MessageId;


            await clients.SendTextMessageAsync(0, "Vorobey pidor", replyToMessageId: 0);
        }
    }
}