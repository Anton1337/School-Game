using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    [SerializeField]
    private Transform following;

    private void Update()
    {
        Vector3 newPos = new Vector3(following.position.x, following.position.y, transform.position.z);
        transform.position = newPos;
    }
}
