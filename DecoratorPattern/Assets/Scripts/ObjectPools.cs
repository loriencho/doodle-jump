using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPools : MonoBehaviour
{

    public static ObjectPools SharedInstance;
    public List<GameObject> pooledCoins = new List<GameObject>();
    public List<GameObject> pooledPlatforms = new List<GameObject>();
    public GameObject coin;
    public int amountCoins;
    public GameObject platform;
    public int amountPlatforms;
   

    void Awake(){
        SharedInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        addToPool(pooledCoins, amountCoins, coin);
        addToPool(pooledPlatforms, amountPlatforms, platform);
    }

    void addToPool(List<GameObject> pool, int amtToPool, GameObject poolObject){
        GameObject tmp;
        for(int i =0; i < amtToPool; i++){
            tmp = Instantiate(poolObject);
            tmp.SetActive(false);
            pool.Add(tmp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
