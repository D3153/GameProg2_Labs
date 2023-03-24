using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnApples : MonoBehaviour
{
    public GameObject apple;
    public float interval = 3;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        // timer = delay;
        // Instantiate(apple);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // var position = new Vector3(Random.Range(-0.1f, 0.9f), transform.position.y,0);
        if (timer>= interval)
        {
            for(int i = 0; i < 5; i++)
            {
                Instantiate(apple, transform.position, Quaternion.identity);
                // position.x +=gap;
            }
            // Instantiate(apple, transform.position, Quaternion.identity);
            timer -= interval;
        }
        Destroy(apple, 5);
    }
}
