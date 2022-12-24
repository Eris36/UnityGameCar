using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed = 1000f;
    private Rigidbody _rb;

    private float rotationX;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        MovementLogic();
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    private void MovementLogic()
    {
        

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-0.5f, 0.0f, 0.0f);

        _rb.AddForce(movement * Speed);
    }

}
