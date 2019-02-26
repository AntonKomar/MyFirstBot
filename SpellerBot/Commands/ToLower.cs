using Microsoft.Bot.Connector;
using SpellerBot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpellerBot.Commands
{
    public class ToLower : ITool
    {
        public string Description { get; set; }
        public List<string> CommandsName { get; set; }
        public bool IsAdmin { get; set; } = false;

        ///<summary>
        ///Text to lowercase
        ///</summary>
        public Activity Run(Activity activity)
        {
            if (activity != null && activity.Conversation != null)
                activity.Text = activity.Text.ToLower();

            return activity;
        }

        public ToLower()
        {
            CommandsName = new List<string>() { "/tolower" };
            Description = "Приводит текст к нижнему регистру";
        }
    }
}