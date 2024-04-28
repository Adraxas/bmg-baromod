using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Barotrauma;
using Barotrauma.Networking;

namespace MyModName
{
    public partial class Plugin : IAssemblyPlugin
    {
        static void InitCommands()
        {
            GameMain.LuaCs.Game.AddCommand("BGM_clientlist", "For Barotrauma Management GUI use only.", (_) =>
            {
                var playerArr = new List<string>();
                foreach (Client c in GameMain.Server.ConnectedClients)
                {
                    playerArr.Add($"{{{c.SessionId} {c.Name}{(c.Character != null ? " playing " + c.Character.LogName : "")}, {c.Connection.Endpoint.StringRepresentation}, {c.Connection.AccountInfo.AccountId}}}");
                }
            });
        }
    }
}  
  