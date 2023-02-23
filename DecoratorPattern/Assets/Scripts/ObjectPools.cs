using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPools : MonoBehaviour
{

    public static ObjectPools SharedInstance;
    public List<Coin> pooledCoins = new List<Coin>();
    public List<Platform> pooledPlatforms = new List<Platform>();
    public List<Powerup> pooledPowerups = new List<Powerup>();

    public GameObject coin;
    public int amountCoins;
    public List<GameObject> powerups;
    public int amountPowerups;
    public GameObject platform;
    public int amountPlatforms;
   

    void Awake(){
        SharedInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject tmp;
        for(int i =0; i < amountCoins; i++){
            tmp = Instantiate(coin);
            tmp.SetActive(false);
            pooledCoins.Add(tmp.GetComponent<Coin>());      
        }
        for(int i =0; i < amountPlatforms; i++){
            tmp = Instantiate(platform);
            tmp.SetActive(false);
            pooledPlatforms.Add(tmp.GetComponent<Platform>());      
        }
        for(int i =0; i < amountPowerups; i++){
            tmp = Instantiate(powerups[i % powerups.Count]);
            tmp.SetActive(false);
            pooledPowerups.Add(tmp.GetComponent<Powerup>());      
        }

    }

    private void randomizePowerupsList(){
        for (int i = 0; i < pooledPowerups.Count; i++) {
            Powerup temp = pooledPowerups[i];
            int randomIndex = Random.Range(i, pooledPowerups.Count);
            pooledPowerups[i] = pooledPowerups[randomIndex];
            pooledPowerups[randomIndex] = temp;
        }
    }

    public Powerup GetPooledPowerup(){
        randomizePowerupsList();
        for(int i = 0; i < amountPowerups; i++)
        {
            if(!pooledPowerups[i].gameObject.activeSelf)
            {
                return pooledPowerups[i];
            }
        }
        Debug.Log("Could not find available powerup");
        return null;
    } 

    public Coin GetPooledCoin(){
        for(int i = 0; i < amountCoins; i++)
        {
            if(!pooledCoins[i].gameObject.activeSelf)
            {
                return pooledCoins[i];
            }
        }
        Debug.Log("Could not find available coin");
        return null;
    } 

    public Platform GetPooledPlatform(){
        for(int i = 0; i < amountPlatforms; i++)
        {
            if(!pooledPlatforms[i].gameObject.activeSelf)
            {
                return pooledPlatforms[i];
            }
        }

        Debug.Log("Could not find available platform");

        return null;
    }

}
