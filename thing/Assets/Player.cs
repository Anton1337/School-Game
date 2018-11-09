using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody2D rb;

    public float speed;
    public float jumpForce;
    public int numberOfJumps = 2;
    public bool isRight;

    public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        Move();
        Jump();
        Shoot();
	}

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if(isRight)
                Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            else
                Instantiate(bulletPrefab, transform.position, Quaternion.LookRotation(-transform.forward, Vector3.up));
        }
    }

    void Move(){
        float dir = Input.GetAxisRaw("Horizontal");

        if (dir < 0)
            isRight = false;
        else if (dir > 0)
            isRight = true;

        rb.velocity = new Vector2(dir * speed * Time.deltaTime, rb.velocity.y);
    }

    void Jump(){
        if (Input.GetKeyDown(KeyCode.W)){
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}