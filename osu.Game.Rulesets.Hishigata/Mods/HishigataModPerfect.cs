﻿using osu.Game.Rulesets.Judgements;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Scoring;

namespace osu.Game.Rulesets.Hishigata.Mods
{
    public class HishigataModPerfect : ModPerfect
    {
        protected override bool FailCondition(HealthProcessor healthProcessor, JudgementResult result)
            => !(result.Judgement is IgnoreJudgement)
               && result.Type < result.Judgement.MaxResult;
    }
}
