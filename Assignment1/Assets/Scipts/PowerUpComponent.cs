using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpComponent : MonoBehaviour
{
    public GameObject powerUp;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Show", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Show()
    {
        powerUp.SetActive(true);
        Invoke("Hide",3f);
    }

    void Hide()
    {
        powerUp.SetActive(false);
        Invoke("Show",3f);
    }

    public void OnTriggerEnter(Collider obj)
    {
        // gameManager = FindObjectOfType<GameManager>();
        if(obj.gameObject.tag == "Player"){
            // Destroy(point);
            // powerUp.SetActive(false);
            Destroy(powerUp);
            CharacterMovement.powerUpTouch = true;
        }
    }
    
}
