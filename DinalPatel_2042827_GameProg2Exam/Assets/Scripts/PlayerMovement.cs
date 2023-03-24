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
        if(Input.GetKey(KeyCode.W)){
            rb.velocity = Vector3.forward;
        }

        if(Input.GetKey(KeyCode.A)){
            rb.velocity = Vector3.left;
        }

        if(Input.GetKey(KeyCode.S)){
            rb.velocity = Vector3.back;
        }

        if(Input.GetKey(KeyCode.D)){
            rb.velocity = Vector3.right;
        }
    }

    public void OnCollisionEnter(Collision obj){
        gameManager = FindObjectOfType<GameManager>();
        if(gameManager != null){
            if(obj.gameObject.tag == "Food")
            {
                gameManager.UpdateScore();
                scoreText.text = "Score: " + gameManager.score;
                scoreSlider.value = gameManager.score;
            }
            if(obj.gameObject.tag == "Enemy")
            {
                gameManager.DecreaseScore();
                scoreText.text = "Score: " + gameManager.score;
                scoreSlider.value = gameManager.score;
            }
        }
    }
}

