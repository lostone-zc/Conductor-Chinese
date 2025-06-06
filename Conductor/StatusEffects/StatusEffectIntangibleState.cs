﻿using ShinyShoe.Logging;

namespace Conductor.StatusEffects
{
    /// <summary>
    /// Example status effect that makes the damage always be one.
    /// </summary>
    class StatusEffectIntangibleState : StatusEffectState
    {
        public const string StatusId = "conductor_intangible";

        public override bool TestTrigger(InputTriggerParams inputTriggerParams, OutputTriggerParams outputTriggerParams, ICoreGameManagers coreGameManagers)
        {
            if (inputTriggerParams.attacked == null)
            {
                Log.Warning(LogGroups.Gameplay, "StatusEffectIntangibleState.OnPreAttacked() attacked character should not be null!");
                return false;
            }
            if (inputTriggerParams.damage > 0)
            {
                outputTriggerParams.damage = 1;
                return true;
            }
            return false;
        }
    }
}
