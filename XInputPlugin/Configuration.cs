using Dalamud.Configuration;
using Dalamud.Plugin;
using System;
using System.Collections.Generic;
using Dalamud.Game.ClientState.Keys;

namespace CrossInput
{
    [Serializable]
    public class Configuration : IPluginConfiguration
    {
        public int Version { get; set; } = 0;

        public List<KeyRebind> RebindList { get; set;} = new List<KeyRebind>();

        internal bool isEnabled { get; set; } = true;

        public void Save()
        {
            CrossInputPlugin.PluginInterface.SavePluginConfig(this);
        }

        internal void RemoveRebind(int locationToRemove)
        {
            RebindList.RemoveAt(locationToRemove);
        }
    }
}
