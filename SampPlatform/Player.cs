﻿using SampSharp.GameMode.Pools;
using SampSharp.GameMode.World;
using System;

namespace SampPlatform {
    [PooledType]
    public class Player : BasePlayer {
        #region Overrides of BasePlayer

        public override void OnConnected(EventArgs e) {
            base.OnConnected(e);

            SendClientMessage("Welcome to blank game mode by your name here!");
        }

        #endregion
    }
}