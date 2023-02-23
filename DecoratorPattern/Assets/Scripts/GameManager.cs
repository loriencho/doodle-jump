using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameObject mainCamera;
    public static float Score {get ; private set;}
    public GameObject player;
    public static TextMeshProUGUI scoreText;
    public GameObject gameOverText;
    public GameObject youWinText;
    
    // Start is called before the first frame update
    void Start()
    {
        youWinText.SetActive(false);
        gameOverText.SetActive(false);
        Score = 0;
        scoreText = GameObject.Find("Score Text").GetComponent<TextMeshProUGUI>();
        mainCamera = GameObject.Find("Main Camera");
        SpawnObjects(2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(mainCamera.transform.position.x, player.transform.position.y, mainCamera.transform.position.z);
        mainCamera.transform.position = position;

        if(player.transform.position.y < (Score -20)){
            gameOverText.SetActive(true);
            if (Input.GetKeyDown("space")){
                SceneManager.LoadScene("Game");
            }
        }
        else if (Score >= 50){
            youWinText.SetActive(true);
            if (Input.GetKeyDown("space")){
                SceneManager.LoadScene("Game");
            }
        }
    }

    static void SpawnObjects(float minimumHeight){
        for (int i=0; i < Random.Range(0, 2); i++){
            ObjectPools.SharedInstance.GetPooledCoin().Spawn(minimumHeight + i*2.5f);
        }
        for (int i=0; i < Random.Range(0, 2); i++){
            ObjectPools.SharedInstance.GetPooledPowerup().Spawn(minimumHeight + i*2.5f);
        }
        for (int i=0; i < Random.Range(2, 3); i++){
            ObjectPools.SharedInstance.GetPooledPlatform().Spawn(minimumHeight + i*2.5f);
        }
    }

    public static void increaseScore(){
        float height = mainCamera.transform.position.y;
        Score = height;
        scoreText.text = "" + Mathf.Floor(height);        

    }

    public static void OnPlatformRemove(){
        increaseScore();
        SpawnObjects(5.0f);
    }

    bool outOfBounds(){
        return (GameManager.getCameraHeight() > transform.position.y);
    }
    
    public static float getCameraHeight(){
        return mainCamera.transform.position.y;
    }
}
