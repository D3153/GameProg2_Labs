using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFruitInteraction : MonoBehaviour
{
    GameManager gm;
    public float score = 0;
    public Slider slider;
    public Text text = "Player Score: ";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        gm = FindObjectOfType<GameManager>();
        if(col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            gm.UpdateScore();
            slider.value = gm.score;

        }
        if(col.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
