using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody2D rb;

    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotateOffset;

    [SerializeField]
    private float timeInbetweenShots;
    private float startTimeInbetweenShots;

    [SerializeField]
    private GameObject bulletPrefab;

	void Start () {
        rb = GetComponent<Rigidbody2D>();

        startTimeInbetweenShots = timeInbetweenShots;
	}
	
	void Update () {

        RotateWithCursor();
        Move();
        Shoot();
	}

    private void RotateWithCursor()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + rotateOffset);
    }

    private void Shoot()
    {
        if(Input.GetMouseButton(0) & startTimeInbetweenShots <= 0)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            startTimeInbetweenShots = timeInbetweenShots;
        } else
        {
            startTimeInbetweenShots -= Time.deltaTime;
        }
    }

    void Move(){
        float xDir = Input.GetAxisRaw("Horizontal");
        float yDir = Input.GetAxisRaw("Vertical");

        Vector2 movement = ( (Camera.main.transform.up * yDir) + 
                           (Camera.main.transform.right * xDir) ).normalized * 
                           speed * Time.deltaTime * 100;
        rb.velocity = movement;
    }
}