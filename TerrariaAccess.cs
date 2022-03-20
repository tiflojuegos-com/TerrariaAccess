using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using DavyKager; // this is the screen reader library

namespace TerrariaAccess
{
    public class TerrariaAccess : Mod
    {
        internal static TerrariaAccess instance;
        public static ModKeybind PlayerCoordinatesKeybind;

        public override void Load()
        {
            instance = this;
            Tolk.Load();
            // Registers a new keybind
            PlayerCoordinatesKeybind = KeybindLoader.RegisterKeybind(this, "PlayerCordinates", "K");
            Tolk.Speak("horray! mod loaded");
        }

    }
}