using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody2D rb;

    public float speed;

    public float jumpForce;

    public int numberOfJumps = 2;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        Move();
        Jump();
	}

    void Move(){
        float dir = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(dir * speed * Time.deltaTime, rb.velocity.y);
    }

    void Jump(){
        if (Input.GetKeyDown(KeyCode.W)){
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}