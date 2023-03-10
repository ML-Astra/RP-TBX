using System;
using Dalamud.Game.Command;

namespace RoleplayersToolbox {
    internal class Commands : IDisposable {
        private Plugin Plugin { get; }

        internal Commands(Plugin plugin) {
            this.Plugin = plugin;

            this.Plugin.CommandManager.AddHandler("/rptbx", new CommandInfo(this.OnCommand) {
                HelpMessage = "Open RP-TBX",
            });
        }

        public void Dispose() {
            this.Plugin.CommandManager.RemoveHandler("/rptbx");
        }

        private void OnCommand(string command, string arguments) {
            this.Plugin.Ui.ShowInterface ^= true;
        }
    }
}
