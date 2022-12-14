using System;
using System.Collections;
using UnityEngine;

namespace Game
{
    public class CarContoll : MonoBehaviour
    {
        private Rigidbody rb; // Объявление новой переменной Rigidbody
        private bool isMovingRight = true; // переменная, отражающая условное направление объекта
        private bool isRotation = true; // переменная, отражающая условное возможности поворота
        public int speed = 3; // Скорость движения авто
        public int timeToStart = 3;
        
        public GameObject DeadUI;
        public GameObject VictoryUI;
        RaycastHit hit;
        
        public AudioSource AudioCloseDor;

        void Start()
        {
            AudioCloseDor = GetComponent<AudioSource>();
            StartCoroutine(ExampleCoroutine());
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
            
            if(Input.GetMouseButtonDown(0)) 
            {
                if (isRotation)
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
                }
                if (hit.collider.gameObject.name == "Finish")
                {
                    isRotation = false;
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
            speed = 0;
        }

        //Делаем паузу на время кат сцены в начале
        IEnumerator ExampleCoroutine()
        {
            int saveSpeed = speed;
            speed = 0;
            isRotation = false;
            yield return new WaitForSeconds(1);
            AudioCloseDor.Play();
            yield return new WaitForSeconds(timeToStart - 1);
            speed = saveSpeed;
            isRotation = true;
            
        }
  }
}
