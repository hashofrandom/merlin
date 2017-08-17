﻿using Merlin.API.Direct;

namespace Merlin
{
    public static class FightingObjectViewExtensions
    {
        public static FightingObject GetFightingObject(this FightingObjectView view) => view.FightingObject;

        public static long GetTargetId(this FightingObjectView view) => view.GetFightingObject().GetTargetId();
    }
}