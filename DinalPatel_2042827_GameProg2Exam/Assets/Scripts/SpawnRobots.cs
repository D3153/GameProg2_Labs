using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRobots : MonoBehaviour
{
    public GameObject robot;
    public float interval = 2;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate(robot);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer>= interval)
        {
            for(int i = 0; i < 5; i++)
            {
                Instantiate(robot, transform.position, Quaternion.identity);
            }
            timer -= interval;
        }
        Destroy(robot, 5);
    }
}
