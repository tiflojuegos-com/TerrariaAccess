using Terraria;
using Terraria.ID;
using Terraria.GameInput;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using DavyKager; // this is the screen reader library

namespace TerrariaAccess
{
    public class PlayerStats: ModPlayer
    {

        public override void ProcessTriggers(TriggersSet triggersSet)
        {
        if(TerrariaAccess.PlayerCoordinatesKeybind.JustPressed)
            {
                 Tolk.Speak("player coords: "+Player.position.X+", "+Player.position.Y);
            }
        }
    }
}
