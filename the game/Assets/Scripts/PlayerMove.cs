using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D playerBody;
    public float speed = 5f; // Movement speed


    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        float verticalInput = Input.GetAxisRaw("Vertical");

        playerBody.velocity = new Vector2 (horizontalInput, verticalInput);
        playerBody.velocity *= speed;

    }
}
