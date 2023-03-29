using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
     
    private static GameManager instance;
    public Text scoreText;
    public static int score = 0;

    public static GameManager Instance {
        get {
            if(instance==null) {
                instance = new GameManager();
            }
 
            return instance;
        }
    }
    
 
    void Awake()
    {
        instance = this;
        DontDestroyOnLoad(scoreText);
    }
 
    public void UpdateScore()
    {
        score += 50;
        scoreText.text = "Score: " + GameManager.score;
        // if ( score == 10)
        // {
        //     SceneManager.LoadScene(0);
        // }
    }
}
