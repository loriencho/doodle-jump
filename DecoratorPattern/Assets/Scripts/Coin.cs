using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, ISpawnableObject
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 PickPosition(){
        return new Vector3(
            Random.Range(-7.7f, 7.7f), 
            GameManager.getCameraHeight()+ 7f,
            0f
        );
    }

    public bool CheckOutOfBounds(){
        return (GameManager.getCameraHeight() > transform.position.y);
    }

    public void Spawn(){
        PickPosition();
    }
}
