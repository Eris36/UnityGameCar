using System;
using UnityEngine;

namespace Game
{
    public class TsunamiDistroy : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.forward * -2 * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Я тронул" + other.name);
            other.gameObject.transform.Translate(Vector3.down * 2 * Time.deltaTime);
        }
    }  
}

