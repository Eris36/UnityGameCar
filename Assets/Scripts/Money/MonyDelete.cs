using System;
using UnityEngine;

namespace Game
{
    public class MonyDelete : MonoBehaviour
    {
        public static Action _addMoney;
        public GameObject particale;


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _addMoney?.Invoke();
                GameObject _particale = Instantiate (particale);
                _particale.transform.position = gameObject.transform.position - new Vector3 (0f,0.3f,0f);;
                Destroy(gameObject);
            }
        }
    }
}
