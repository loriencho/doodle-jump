using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool outOfBounds(){
        return (GameManager.getCameraHeight() > transform.position.y);
    }
    
    public static float getCameraHeight(){
        return mainCamera.transform.position.y;
    }
}
