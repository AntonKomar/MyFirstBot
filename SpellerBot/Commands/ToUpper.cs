using Microsoft.Bot.Connector;
using SpellerBot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpellerBot.Commands
{
    public class ToUpper : ITool
    {
        public string Description { get; set; }
        public List<string> CommandsName { get; set; }
        public bool IsAdmin { get; set; } = false;

        ///<summary>
        ///Text to uppercase
        ///</summary>
        public Activity Run(Activity activity)
        {
            if(activity != null && activity.Conversation != null)
                activity.Text = activity.Text.ToUpper();

            return activity;

        }

        public ToUpper()
        {
            CommandsName = new List<string>() { "/toupper" };
            Description = "Приводит текст к верхнему регистру";
        }
    }
}