using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlaneRestart : MonoBehaviour
{
    void OnTriggerEnter(Collider col) {
        if(col.CompareTag("Player")){
            SceneManager.LoadScene(0);
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
