﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ARQuestCreator.MiniGames.TubeGame
{
    public class TubeController : BaseTubeController
    {
        private readonly Vector2[] giveDirs = new Vector2[] { Vector2.right, Vector2.left };

        protected override Vector2[] GetDefaultGiveDirections()
        {
            return giveDirs;
        }
    }
}
