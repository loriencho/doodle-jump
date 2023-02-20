using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour, ISpawnableObject
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool CheckOutOfBounds(){
        // return false;
        return (GameManager.getCameraHeight() > transform.position.y);
    }

    public void Spawn(){
        transform.localScale =  new Vector3(Random.Range(3f, 5f), transform.localScale.y, transform.localScale.z);
    }

    public Vector3 PickPosition(){
        return new Vector3(
            Random.Range(-7.7f, 7.7f), 
            GameManager.getCameraHeight()+ 7f,
            0f
        );
    }
}
