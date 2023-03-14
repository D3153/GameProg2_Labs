using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 2;
    public GameManager gameManager;
    public Text scoreText;
    public Slider scoreSlider;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal")*speed,rb.velocity.y,0);
        rb.velocity = move;
    }

    public void OnCollisionEnter(Collision obj){
        gameManager = FindObjectOfType<GameManager>();
        if(gameManager != null){
            if(obj.gameObject.tag == "Fruit")
            {
                gameManager.UpdateScore();
                scoreText.text = "Score: " + gameManager.score;
                scoreSlider.value = gameManager.score;
            }
        }
    }
}
