using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/JumpBoost")]
public class JumpBoost : PowerupEffect
{
    public float velocityY;
    public override void Apply(GameObject target)
    {
        Rigidbody2D rb = target.GetComponent<Rigidbody2D>();
        Vector2 velocity = rb.velocity;
        velocity.y = velocityY;
        rb.velocity = velocity;   
    }
}
