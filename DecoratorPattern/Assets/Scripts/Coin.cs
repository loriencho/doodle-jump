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
        if (CheckOutOfBounds()) {
            Despawn();
        } 
    }

    public Vector3 PickPosition(float minimumHeight){
        return new Vector3(
            Random.Range(-7.7f, 7.7f), 
            GameManager.getCameraHeight() + minimumHeight,
            0f
        );
    }

    public bool CheckOutOfBounds(){
        return (GameManager.getCameraHeight() -7f > transform.position.y);
    }

    public void Spawn(float minimumHeight){
        gameObject.SetActive(true);
        transform.position = PickPosition(minimumHeight);
    }

    public void Despawn(){
        gameObject.SetActive(false);
    }
}
