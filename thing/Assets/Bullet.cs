using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public int damage = 1;

    public int speed = 10;

    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

}
