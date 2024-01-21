using System;
using System.Numerics;
using Dalamud.Interface.Windowing;
using ImGuiNET;

using Dalamud.Game.ClientState.Keys;
using Dalamud.Interface.Utility.Raii;
using Dalamud.Interface.Components;
using Dalamud.Interface;

namespace CrossInput.Windows;

public class ConfigWindow : Window, IDisposable
{
    private Configuration Configuration;

    private string tempSourceLocation = String.Empty;
    private string tempDestinationLocation = String.Empty;

    public ConfigWindow(CrossInputPlugin plugin) : base(
        "XInput Configuration Window")
    {
        this.Size = new Vector2(600, 800);
        this.SizeCondition = ImGuiCond.FirstUseEver;

        this.Configuration = plugin.Configuration;
    }

    public void Dispose() { }

    public override void Draw()
    {
        bool enable = this.Configuration.isEnabled;
        if (ImGui.Checkbox("Enable Global Key Remapping", ref enable))
        {
            this.Configuration.isEnabled = enable;
            this.Configuration.Save();
        }

        ImGui.Separator();

        DrawKeybinds();

        ImGui.Separator();

        if (ImGui.Button("Add Defaults"))
        {
            Configuration.RebindList.Add(new KeyRebind(VirtualKey.XBUTTON1, VirtualKey.LSHIFT));
            Configuration.RebindList.Add(new KeyRebind(VirtualKey.XBUTTON2, VirtualKey.LCONTROL));
        }
        /*// can't ref a property, so use a local copy
        *//*var configValue = this.Configuration.SomePropertyToBeSavedAndWithADefault;*//*
        if (ImGui.Checkbox("Random Config Bool", ref configValue))
        {
            *//*this.Configuration.SomePropertyToBeSavedAndWithADefault = configValue;*//*
            // can save immediately on change, if you don't want to provide a "Save and Close" button
            this.Configuration.Save();
        }*/
    }

    private void DrawKeybinds()
    {
        ImGui.Text("Keybinds");

        ImGui.Columns(5);

        ImGui.Separator();

        ImGui.TextUnformatted("Source Key");
        ImGui.NextColumn();
        ImGui.TextUnformatted("Destination Key");
        ImGui.NextColumn();
        ImGui.TextUnformatted("Pressed");
        ImGui.NextColumn();
        ImGui.TextUnformatted("Enabled");
        ImGui.NextColumn();
        ImGui.TextUnformatted(string.Empty);
        ImGui.NextColumn();

        ImGui.Separator();

        int locationToRemove = -1;

        for (int i = 0; i < Configuration.RebindList.Count; i++) 
        {

            KeyRebind kb = Configuration.RebindList[i];

            bool isEnabled = kb.isEnabled;

            ImGui.Text(kb.SourceKey.ToString());
            ImGui.NextColumn();
            ImGui.Text(kb.DestinationKey.ToString());
            ImGui.NextColumn();
            ImGui.Text(kb.isHeld.ToString());
            ImGui.NextColumn();
            if (ImGui.Checkbox($"##{i}isEnabled", ref isEnabled))
            {
                kb.isEnabled = isEnabled;
            }
            ImGui.NextColumn();
            if (ImGuiComponents.IconButton($"##{i}trashIcon",FontAwesomeIcon.Trash))
            {
                locationToRemove = i;
            }
            ImGui.NextColumn();

            ImGui.Separator();
        }

        if (locationToRemove > -1)
        {
            Configuration.RemoveRebind(locationToRemove);
            locationToRemove = -1;
        }

        ImGui.InputText("##sourcekey", ref tempSourceLocation, 300);
        ImGui.NextColumn();
        ImGui.InputText("##destkey", ref tempDestinationLocation, 300);
        ImGui.NextColumn();
        ImGui.Text(String.Empty);
        ImGui.NextColumn();
        ImGui.Text(String.Empty);
        ImGui.NextColumn();
        if (InputIsValid() && ImGuiComponents.IconButton(FontAwesomeIcon.Plus))
        {
            CreateNewKeyBind(tempSourceLocation, tempDestinationLocation);

            tempSourceLocation = string.Empty;
            tempDestinationLocation = string.Empty;
        }

        ImGui.Columns(1);

        Configuration.Save();
    }

    private void CreateNewKeyBind(string tempSourceLocation, string tempDestinationLocation)
    {
        bool sBool = Enum.TryParse(tempSourceLocation, out VirtualKey sourceKey);
        bool dBool = Enum.TryParse(tempDestinationLocation, out VirtualKey destinationKey);

        if(sBool && dBool)
        {
            KeyRebind keyRebind = new KeyRebind(sourceKey, destinationKey);
            Configuration.RebindList.Add(keyRebind);
        }
    }

    private bool InputIsValid()
    {
        bool sBool = Enum.TryParse(tempSourceLocation, out VirtualKey sourceKey);
        bool dBool = Enum.TryParse(tempDestinationLocation, out VirtualKey destinationKey);

        return (sBool && dBool);

    }

    private bool InputSourceIsValid()
    {
        return Enum.TryParse(tempSourceLocation, out VirtualKey sourceKey);
    }
    private bool InputDestinationIsValid()
    {
        return Enum.TryParse(tempDestinationLocation, out VirtualKey destinationKey);
    }
}
