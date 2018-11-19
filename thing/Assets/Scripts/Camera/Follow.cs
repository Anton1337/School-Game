using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Follow : MonoBehaviour {

    [SerializeField]
    private Transform following;

    [SerializeField]
    //private RectTransform UIPanel;

    private float playerCenterOffset;

    private void Awake()
    {
        //playerCenterOffset = UIPanel.rect.width / 2;
        Debug.Log(playerCenterOffset);
    }

    private void Update()
    {
        //TODO: - Fix centering of player.
        Vector3 newPos = new Vector3(following.position.x /*+(playerCenterOffset / 70)*/, 
                                     following.position.y, transform.position.z);
        transform.position = newPos;
    }
}
