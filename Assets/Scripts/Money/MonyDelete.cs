using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class MonyDelete : MonoBehaviour
    {
        public static Action _addMoney;
        public GameObject particale;
        private void Start()
        {
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<CarInventar>())
            {
                _addMoney?.Invoke();
                other.gameObject.GetComponent<CarInventar>().AddMony();
                GameObject _particale = Instantiate (particale);
                _particale.transform.position = gameObject.transform.position - new Vector3 (0f,0.3f,0f);;
                Destroy(gameObject);

            }
        }
    }
}
