using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : PowerupEffectDecorator
{
    public float velocityY = 10f;

    public JumpBoost(IPoweredupPlayer player) : base(player){}

    public override void Apply(GameObject target)
    {
        Rigidbody2D rb = target.GetComponent<Rigidbody2D>();
        Vector2 velocity = rb.velocity;
        velocity.y = velocityY;
        rb.velocity = velocity;   
    }
}
