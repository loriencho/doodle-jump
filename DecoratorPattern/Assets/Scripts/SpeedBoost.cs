using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : PowerupEffectDecorator
{
    public float amount = .5f;

    public SpeedBoost(IPoweredupPlayer player) : base(player){}

    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerController>().moveSpeed += amount;
    }
}
