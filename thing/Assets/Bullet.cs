using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public int damage = 1;

    public int speed = 10;

    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

}
