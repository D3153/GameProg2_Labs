using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
     
    private static GameManager instance;

    public int score = 0;
    // public static Text text;
    // public static Slider slider;

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
    }
 
    public void UpdateScore()
    {
        score += 1;
    }

    public void DecreaseScore()
    {
        score -= 1;
    }
}
