using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour, ISpawnableObject
{
    public Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckOutOfBounds()) {
            Despawn();
        }
    }

    public bool CheckOutOfBounds(){

        return (GameManager.getCameraHeight() - 6 >= transform.position.y);
    }

    public void Spawn(float minimumHeight){
        transform.localScale =  new Vector3(Random.Range(2f, 3f), transform.localScale.y, transform.localScale.z);
        transform.position = PickPosition(minimumHeight);
        gameObject.SetActive(true);
    }

    public void Despawn(){
        gameObject.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.position.y >= transform.position.y){
            Vector2 velocity = playerRb.velocity;
            velocity.y = 10f;
            playerRb.velocity = velocity;    
            GameManager.OnPlatformRemove();
            Despawn();
        }
    }

    public Vector3 PickPosition(float minimumHeight){
        return new Vector3(
            Random.Range(-7.7f, 7.7f), 
            GameManager.getCameraHeight()+ minimumHeight,
            0f
        );
    }
}
