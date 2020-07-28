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
            string textFile = Directory.GetCurrentDirectory() + @"\config\players.txt";
            string text = File.ReadAllText(textFile);

            await ReplyAsync(text);
        }

        [Command("invite")]
        public async Task Invite()
        {
            await ReplyAsync("https://discord.gg/mmxH4dN");
        }
    }
}
