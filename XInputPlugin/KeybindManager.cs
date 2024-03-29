using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Dalamud.Game.ClientState.Keys;
using Dalamud.Plugin.Services;

namespace CrossInput
{
    public static class KeybindManager
    {

        private static Configuration Configuration;

        [DllImport("User32.dll")]
        public static extern bool GetAsyncKeyState(VirtualKey vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void keybd_event(uint bVk, uint bScan, uint dwFlags, uint dwExtraInfo);

        // directly sends a key event
        public static void SendKeyEvent(VirtualKey key, bool isUp = false)
        {
            int dwFlags = isUp ? 0x0002 : 0x0000;
            keybd_event(((uint)key), 0, (uint)dwFlags, 0);
        }

        // used to simulate a key press, down and then up
        public static void SimulateKeyPress(VirtualKey key)
        {
            SendKeyEvent(key, false); //keydown event
            SendKeyEvent(key, true); //keyup event
        }

        internal static void OnUpdate(IFramework framework)
        {
            if (Configuration.isEnabled)
            {
                foreach (var keybind in Configuration.RebindList)
                {
                    if(keybind.isEnabled) keybind.Update();
                }
            }
            
        }

        internal static void UpdateConfiguration(Configuration cfg)
        {
            Configuration = cfg;
        }
    }
}
