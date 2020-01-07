using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float min = -4.5f;
    public float max = 4.5f;

    float random = 0f;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(1, 10);
        


    }

    // Update is called once per frame
    void Update()
    {
            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time*random, max - min) + min);
    }
}
