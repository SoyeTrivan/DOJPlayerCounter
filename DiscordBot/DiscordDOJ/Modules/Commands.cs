using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoyeAPI;

namespace DiscordDOJ.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("players")]
        public async Task Players()
        {
            string textFile = DOJScriptHelper.ScriptLocation() + "players.txt";
            string text = File.ReadAllText(textFile);

            await ReplyAsync(text);
        }
    }
}
