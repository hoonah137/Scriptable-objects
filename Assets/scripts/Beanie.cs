using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beanie : MonoBehaviour
{
    Rigidbody2D rigidBody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * 5, rigidBody2D.velocity.y);
    }
}
