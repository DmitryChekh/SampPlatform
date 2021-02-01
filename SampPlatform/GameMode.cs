using SampSharp.GameMode;
using SampSharp.GameMode.World;
using System;

namespace SampPlatform {
    public class GameMode : BaseMode {
        #region Overrides of BaseMode

        protected override void OnInitialized(EventArgs e) {
            base.OnInitialized(e);

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine(" Blank game mode by your name here");
            Console.WriteLine("----------------------------------\n");

            // TODO: Put logic to initialize your game mode here
        }

        #endregion

        protected override void OnPlayerConnected(BasePlayer player, EventArgs e) {
            player.SendClientMessage($"Welcome, {player.Name}! You are now a millionaire!");
        }
    }
}