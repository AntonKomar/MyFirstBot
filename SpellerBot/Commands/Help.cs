using Microsoft.Bot.Connector;
using SpellerBot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpellerBot.Commands
{
    public class Help : ITool
    {
        public string Description { get; set; }
        public List<string> CommandsName { get; set; }
        public bool IsAdmin { get; set; }
        public Activity Run(Activity activity)
        {
            if (activity != null && activity.Conversation != null)
            {
                activity.Text = "Попробуйте ввести другую команду...";
            }
            return activity;
        }

        public Help()
        {
            CommandsName = new List<string>() { "/help" };
            Description = "Оказание помощи";
        }
    }
}