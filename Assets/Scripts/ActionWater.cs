using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionWater : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame

    public void StopPosition()
    {
        rb.velocity = new Vector3 (0f, 0, 0f);
    }
}
