using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Note to self don't forget to create empty in the scene for the game manager

    public static GameManager Instance {get; private set;}
    public int score;


    private void Awake(){
        Instance = this;
    }

}
