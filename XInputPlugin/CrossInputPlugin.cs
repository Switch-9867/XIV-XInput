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

        private DalamudPluginInterface PluginInterface { get; init; }
        private ICommandManager CommandManager { get; init; }
        public Configuration Configuration { get; init; }

        public WindowSystem WindowSystem = new("FFXIV Input");

        private ConfigWindow ConfigWindow { get; init; }

        public IPluginLog Logger { get; init; }


        public CrossInputPlugin(
            [RequiredVersion("1.0")] DalamudPluginInterface pluginInterface,
            [RequiredVersion("1.0")] ICommandManager commandManager,
            [RequiredVersion("1.0")] IFramework gameFramework,
            [RequiredVersion("1.0")] IPluginLog logger
            )
        {

            Logger = logger;


            this.PluginInterface = pluginInterface;
            this.CommandManager = commandManager;

            this.Configuration = this.PluginInterface.GetPluginConfig() as Configuration ?? new Configuration();
            this.Configuration.Initialize(this.PluginInterface);

            KeybindManager.UpdateConfiguration(this.Configuration);
            gameFramework.Update += KeybindManager.OnUpdate;

            // you might normally want to embed resources and load them from the manifest stream
            var imagePath = Path.Combine(PluginInterface.AssemblyLocation.Directory?.FullName!, "goat.png");
            var goatImage = this.PluginInterface.UiBuilder.LoadImage(imagePath);

            ConfigWindow = new ConfigWindow(this);
            
            WindowSystem.AddWindow(ConfigWindow);

            this.CommandManager.AddHandler(CommandName, new CommandInfo(OnCommand)
            {
                HelpMessage = "A useful message to display in /xlhelp"
            });

            this.PluginInterface.UiBuilder.Draw += DrawUI;
        }

        public void Dispose()
        {
            this.WindowSystem.RemoveAllWindows();
            
            ConfigWindow.Dispose();
            
            this.CommandManager.RemoveHandler(CommandName);
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
