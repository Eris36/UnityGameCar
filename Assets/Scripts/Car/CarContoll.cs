using System;
using UnityEngine;

namespace Game
{
    public class CarContoll : MonoBehaviour
    {
        private Rigidbody rb; // Объявление новой переменной Rigidbody
        private bool isMovingRight = true; // переменная, отражающая условное направление объекта
        private float speed = 3f; // Скорость движения авто
        
        public GameObject DeadUI;
        public GameObject VictoryUI;
        RaycastHit hit;

        void Start() {
            rb = GetComponent<Rigidbody> (); // Получение доступа к Rigidbody
        }

        void changeDirection() {
          if (isMovingRight) {
            isMovingRight = false;
		    transform.Rotate(0, -90, 0);
          } else {
            isMovingRight = true;
		    transform.Rotate(0, 90, 0);
          }
	    }

        void Update() {

            if(Input.GetMouseButtonDown(0)) {
                if (hit.collider.gameObject.name != "Finish")
                    changeDirection();
            }

            if (isMovingRight) {
                rb.velocity = new Vector3 (speed, 0f, 0f);
            } else {
                rb.velocity = new Vector3 (0f, 0f, speed);
            }
            
            //Проверка, что можина движется по пути, если нет то падение.
            
            if(Physics.Raycast (transform.position, Vector3.down, out hit, 5f) && hit.transform.gameObject.tag == "Ground") {
                rb.useGravity = false;
                
                //Лучём провряется какой блок был пройден и включение у него разрушения.
                if (hit.collider.gameObject.GetComponent<RoadDestruction>())
                {
                    hit.collider.gameObject.GetComponent<RoadDestruction>().Visited();
                }
                if (hit.collider.gameObject.GetComponent<ActionWater>())
                {
                    throw new ArgumentOutOfRangeException();
                    hit.collider.gameObject.GetComponent<ActionWater>().StopPosition();
                }
                if (hit.collider.gameObject.name == "Finish")
                {
                    Victory();
                }
            } else
            {
                Fall();
            }
        }

        void Fall()
        {
            rb.useGravity = true;
            rb.velocity = new Vector3 (0f,-10f, 0f);
            Invoke ("GameOwer", 0.1f);
        }
        
        void GameOwer()
        {
            DeadUI.SetActive(true);
            Time.timeScale = 0;
        }

        void Victory()
        {
            VictoryUI.SetActive(true);
            speed = 0f;
        }
    }
}
