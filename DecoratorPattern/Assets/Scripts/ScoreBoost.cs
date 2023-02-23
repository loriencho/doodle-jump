using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/ScoreBoost")]
public class ScoreBoost : PowerupEffect
{
    public float amount;
    public override void Apply(GameObject target)
    {
        GameManager.increaseScoreByAmt(amount);

        //target.GetComponent<GameManager>().Score += amount;
    }
}
