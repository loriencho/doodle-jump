using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public Player player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.name.Equals("SpeedBoost"))
            new SpeedBoost(player).Apply(collision.gameObject);
        else if (gameObject.name.Equals("JumpBoost"))
            new JumpBoost(player).Apply(collision.gameObject);
        else if (gameObject.name.Equals("NegativeScore"))
            new ScoreBoost(player).Apply(collision.gameObject);

        Despawn();

    }

    void Update()
    {
        if (CheckOutOfBounds())
        {
            Despawn();
        }
    }

    public Vector3 PickPosition(float minimumHeight)
    {
        return new Vector3(
            Random.Range(-7.7f, 7.7f),
            GameManager.getCameraHeight() + minimumHeight,
            0f
        );
    }

    public bool CheckOutOfBounds()
    {
        return (GameManager.getCameraHeight() - 20f > transform.position.y);
    }

    public void Spawn(float minimumHeight)
    {
        gameObject.SetActive(true);
        transform.position = PickPosition(minimumHeight);
    }

    public void Despawn()
    {
        gameObject.SetActive(false);
    }
}
