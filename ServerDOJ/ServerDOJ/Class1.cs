using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;
using SoyeAPI;

namespace ServerDOJ
{
    public class DOJScriptServer : BaseScript
    {
        public DOJScriptServer()
        {
            Tick += OnTick;
        }

        private async Task OnTick()
        {
            int playerCount = GetNumPlayerIndices();

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(DOJScriptHelper.ScriptLocation() + @"\config", "players.txt"), false))
            {
                outputFile.WriteLine(playerCount);
            }
            await Delay(10000);
        }
    }
}
