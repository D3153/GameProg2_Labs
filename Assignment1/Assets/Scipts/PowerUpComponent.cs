using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpComponent : MonoBehaviour
{
    public GameObject PowerUp;
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
        PowerUp.SetActive(true);
        Invoke("Hide",3f);
    }

    void Hide()
    {
        PowerUp.SetActive(false);
        Invoke("Show",3f);
    }

    
}
