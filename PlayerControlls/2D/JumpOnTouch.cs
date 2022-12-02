using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnTouch : MonoBehaviour {

    // Set public Varaible for the Jump Speed "Velocity"
    public float velocity = 1;

    // Set Rigidbody
    private Rigidbody2D rb;

    void Start () {
        // Initialize Rigidbody on Script/Game start
        rb = GetComponent<Rigidbody2D>();
    }

    void Update () {
        // MouseButton(0) is left click or one finger touch
        if(Input.GetMouseButtonDown(0))
        {
            // if true: Move Rigidbody up
            rb.velocity = Vector2.up * velocity;
        }
    }
}
