using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlaneCol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void OnCollisionEnter(Collision col)
    // {
    //     // SceneManager.LoadScene(SceneManager.GetActiveScene());
    //     SceneManager.LoadScene(1);
    // }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player")){
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene(2);
        }
    }
}
