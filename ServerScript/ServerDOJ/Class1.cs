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

            string filePath = DOJScriptHelper.ScriptLocation() + "__resource.lua";
            string docPath = Path.GetDirectoryName(filePath);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "players.txt"), false))
            {
                outputFile.WriteLine(playerCount);
            }
            Console.WriteLine(playerCount);
            await Delay(10000);
        }
    }
}
