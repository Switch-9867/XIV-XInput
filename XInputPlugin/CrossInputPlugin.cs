using Dalamud.Game.Command;
using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Game;
using System.IO;
using Dalamud.Interface.Windowing;
using Dalamud.Plugin.Services;
using CrossInput.Windows;
using System.Runtime.InteropServices;
using System;

namespace CrossInput
{
    public sealed class CrossInputPlugin : IDalamudPlugin
    {
        public string Name => "FFXIV Input";
        private const string CommandName = "/xinput";

        [PluginService] internal static IDalamudPluginInterface PluginInterface { get; private set; } = null!;
        [PluginService] internal static ICommandManager CommandManager { get; private set; } = null!;
        [PluginService] internal static IPluginLog Logger { get; private set; } = null!;
        [PluginService] internal static IFramework GameFramework { get; private set; } = null!;

        public Configuration Configuration { get; init; }
        public WindowSystem WindowSystem = new("FFXIV Input");
        private ConfigWindow ConfigWindow { get; init; }



        public CrossInputPlugin()
        {

            Configuration = PluginInterface.GetPluginConfig() as Configuration ?? new Configuration();

            KeybindManager.UpdateConfiguration(this.Configuration);

            GameFramework.Update += KeybindManager.OnUpdate;

            ConfigWindow = new ConfigWindow(this);
            
            WindowSystem.AddWindow(ConfigWindow);

            CommandManager.AddHandler(CommandName, new CommandInfo(OnCommand)
            {
                HelpMessage = "Opens the configuration window."
            });

            PluginInterface.UiBuilder.Draw += DrawUI;
        }

        public void Dispose()
        {
            WindowSystem.RemoveAllWindows();
            
            ConfigWindow.Dispose();
            
            CommandManager.RemoveHandler(CommandName);
        }

        private void OnCommand(string command, string args)
        {
            // in response to the slash command, just display our main ui
            ConfigWindow.IsOpen = true;
        }

        private void DrawUI()
        {
            this.WindowSystem.Draw();
        }
    }
}
