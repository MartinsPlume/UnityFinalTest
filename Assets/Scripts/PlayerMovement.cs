using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Stats")]
    public float acceleration;

    [Header("Reference")]
    public Rigidbody player;

    [Header("Code Data")]
    private Vector3 movement;
    private Vector3 start = new Vector3(0, 0.25f, 0);

    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        float verticalMovement = Input.GetAxis("Vertical");
        float horizontalMovement = Input.GetAxis("Horizontal");

        movement = new Vector3(horizontalMovement, 0, verticalMovement);

        player.AddForce(movement * acceleration);

        if (player.transform.position.y < 0)
        {
            player.MovePosition(start);
        }
    }
}
