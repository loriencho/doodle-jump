using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoost : PowerupEffectDecorator
{
    public float amount = -10f;

    public ScoreBoost(IPoweredupPlayer player) : base(player){}

    public override void Apply(GameObject target)
    {
        GameManager.increaseScoreByAmt(amount);

    }
}
