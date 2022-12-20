using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    void Start () {
        offset = transform.position - player.transform.position;
    }
	
    void Update () {
        transform.position = player.transform.position + offset;
    }
}
