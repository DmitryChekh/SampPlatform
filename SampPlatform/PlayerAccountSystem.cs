using SampSharp.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace SampPlatform {
    class PlayerAccountSystem : ISystem {

        [Event]
        public void OnPlayerConnect(Player player) {
            player.SendClientMessage($"Welcome, {player.Name}! You are now a millionaire!");
        }
    }
}
