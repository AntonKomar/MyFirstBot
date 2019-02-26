using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellerBot.Interfaces
{

    ///<summary>
    ///Command interface
    ///</summary>
   
    interface ITool
    {
        string Description { get; set; }

        List<string> CommandsName { get; set; }

        bool IsAdmin { get; set; }

        Activity Run(Activity activity);
    }
}
