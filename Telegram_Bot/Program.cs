using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using NLog;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBotExperiments
{
    class Program
    {
        private static ITelegramBotClient bot = new TelegramBotClient("5526082175:AAGC9NaazJ5BGrgQ6u2kApQnnN8aSU71Vwo");
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                Console.WriteLine($"{message.Chat.FirstName} | {message.Text}");
                if (message.Text.ToLower() == "привет")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Добро пожаловать!");
                    return;
                }
                await botClient.SendTextMessageAsync(message.Chat.Id, "Привет!");
            }
        }
         //static void SendInline(long chatId, CancellationToken cancellationToken)
         //   InlineKeyboardMarkup inlineKeyboard = new(new[])
         //   { new[]
         //   {
         //       InlineKeyboardButton.WithCallbackData(text: "Кнопка_1", callbackData: "key_1"),
         //       InlineKeyboardButton.WithCallbackData(text: "Кнопка_2", callbackData: "key_2"),
         //   },
         //   };



        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
             Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }
        
        //private async Task HandlUpdate

        //{
        //if (Update != null)
        //    {
        //    var masage = update.mesage;

        


        static void Main(string[] args)
        {
            Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );
            Console.ReadLine();
        }
    }
}