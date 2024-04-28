using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Barotrauma;
using HarmonyLib;

namespace MyModName
{
    public partial class Plugin : IAssemblyPlugin
    {
        luac
    }
    public static class Patcher
    {
        public static void DoPatching()
        {
            var harmony = new Harmony("com.aptitude.baro");
            harmony.PatchAll();

        }
    }
    [HarmonyPatch(typeof(Barotrauma.DebugConsole.Command))]
    [HarmonyPatch(nameof(Barotrauma.DebugConsole.Command))]
    static class Patch
    {
        [HarmonyPostfix]
        static void NewCommands()
        {
            var meth = Traverse.Create<Command>().Method("InitProjectSpecific").GetValue();
            meth.commands.add
        }
    }
}
