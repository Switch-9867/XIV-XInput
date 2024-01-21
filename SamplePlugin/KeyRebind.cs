using Dalamud.Game.ClientState.Keys;
using System;
using System.Runtime.InteropServices;

///
/// SEE BELOW FOR VirtualKey Codes
/// https://goatcorp.github.io/Dalamud/api/Dalamud.Game.ClientState.Keys.VirtualKey.html
///

namespace CrossInput
{
    public class KeyRebind(VirtualKey sourceKey, VirtualKey destinationKey)
    {
        public bool isEnabled { get; set; } = true;
        public bool isHeld { get; private set; }
        public bool isHeldLastFrame { get; private set; }
        public bool onKeyDown { get {  return isHeld && !isHeldLastFrame; } }
        public bool onKeyUp { get { return !isHeld && isHeldLastFrame; } }
        public VirtualKey SourceKey { get; private set; } = sourceKey;
        public VirtualKey DestinationKey { get; private set; } = destinationKey;

        public void Update()
        {
            isHeldLastFrame = isHeld;
            isHeld = KeybindManager.GetAsyncKeyState(SourceKey);

            if(onKeyDown) KeybindManager.SendKeyEvent(DestinationKey, false);
            if(onKeyUp) KeybindManager.SendKeyEvent(DestinationKey, true);

        }
    }
}
