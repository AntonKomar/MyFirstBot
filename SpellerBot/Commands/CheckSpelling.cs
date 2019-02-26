using Microsoft.Bot.Connector;
using SpellerBot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using YandexLinguistics.NET;

namespace SpellerBot.Commands
{
    public class CheckSpelling:ITool
    {
        public string Description { get; set; }
        public List<string> CommandsName { get; set; }
        public bool IsAdmin { get; set; } = false;

        ///<summary>
        ///Checking message on spell mistakes
        ///</summary>
        public Activity Run(Activity activity)
        {
            if (activity != null && activity?.Conversation != null) {
                var text = activity?.Text ?? string.Empty;
                var yandexSpeller = new Speller();
                var yandexSpellerResult = yandexSpeller.CheckText(text);

                var resultText = new StringBuilder(text);

                if (yandexSpellerResult.Errors.Any())
                {
                    var shift = 0;
                    foreach (var error in yandexSpellerResult.Errors)
                    {
                        resultText.Insert(error.Position + shift, "**");
                        resultText.Insert(error.Position + error.Length + shift + 2, "**");
                        resultText.Append($"\n\r**{error.Word}**: {error.Steer}");
                        shift += 4;
                    }
                }
                activity.Text = resultText.ToString();
            }
            return activity;
        }
        
        public CheckSpelling()
        {
            CommandsName = new List<string>() { "/check" };
            Description = "Проверяет текст на ошибки";
        }
    }
}

