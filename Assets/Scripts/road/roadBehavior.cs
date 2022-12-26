using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;
using JetBrains.Annotations;
using Random = UnityEngine.Random;

namespace Game
{
    public class roadBehavior : MonoBehaviour
    {
        public GameObject road_1;// Префаб участка пути 1
        public GameObject road_2;// Префаб участка пути 2

        public GameObject road_Finish;// Префаб участка Финиша
        public int number = 1;
        
        public GameObject TimeController;
        private float timeGame;
        private Vector3 lastpos = new Vector3 (0f,0f,0f); // Координаты установленного префаба

        void Start()
        {
            SpawnFirstPlatform();
            InvokeRepeating ("SpawnPlatform", 1f, 1.5f);    
        }

        private void Update()
        {
            timeGame = TimeController.GetComponent<TimeController>()._timeStart;
            int random1 = Random.Range(1, 3);
            number = random1;
        }

        void SpawnFirstPlatform()
        {
            GameObject _platformFirst = Instantiate (road_1);
            _platformFirst.transform.position = lastpos + new Vector3 (3f,0f,0f);
            lastpos = _platformFirst.transform.position;
        }

        void SpawnPlatform()
        {
            if(timeGame >= 0)
            {
                int random = number;
                GameObject _platform;
                switch (random)
                {
                    case 1:
                        _platform = Instantiate(road_1);
                        _platform.transform.position = lastpos + new Vector3(3, 0, 0);
                        lastpos = _platform.transform.position;
                        break;
                    case 2:
                        _platform = Instantiate (road_2);
                        _platform.transform.position = lastpos + new Vector3 (0,0,3);
                        lastpos = _platform.transform.position;
                        break; 
                }
            }
            else
            {
                GameObject _platform = Instantiate (road_Finish) as GameObject;
                _platform.transform.position = lastpos + new Vector3 (3f,0f,0f);
                lastpos = _platform.transform.position;
                CancelInvoke();
            }
        }
    }
}