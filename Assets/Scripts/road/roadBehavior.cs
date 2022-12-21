using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game
{
    public class roadBehavior : MonoBehaviour
    {
        public GameObject road_1;// Префаб участка пути 1
        public GameObject road_2;// Префаб участка пути 2
        public GameObject road_3;// Префаб участка Финиша
        
        public GameObject TimeController;
        private float timeGame;
        
        private Vector3 lastpos = new Vector3 (0f,0f,0f); // Координаты установленного префаба

        void Start()
        {
            InvokeRepeating ("SpawnFirstPlatform", 2f, 1f); 
            //запускакет генеротор дороги через секунду
            InvokeRepeating ("SpawnPlatform", 3f, 1f);    
        }

        private void Update()
        {
            timeGame = TimeController.GetComponent<TimeController>()._timeStart;
        }

        void SpawnFirstPlatform()
        {
            for(int i=0; i<2; i++) {
                GameObject _platform = Instantiate (road_1);
                _platform.transform.position = lastpos + new Vector3 (3f,0f,0f);
                lastpos = _platform.transform.position;
            }
        }

        void SpawnPlatform() {
            if(timeGame >= 0){
                int random = Random.Range (0, 2);
                if (random == 0) { // Установить префаб по оси X
                    GameObject _platform = Instantiate (road_1) as GameObject;
                    _platform.transform.position = lastpos + new Vector3 (3f,0f,0f);
                    lastpos = _platform.transform.position;
                } else { // Установить префаб по оси Z
                    GameObject _platform = Instantiate (road_2) as GameObject;
                    _platform.transform.position = lastpos + new Vector3 (0f,0f,3f);
                    lastpos = _platform.transform.position;
                }
            }
            else
            {
                GameObject _platform = Instantiate (road_3) as GameObject;
                _platform.transform.position = lastpos + new Vector3 (3f,0f,0f);
                lastpos = _platform.transform.position;
                CancelInvoke();
            }   
        }
        
        IEnumerator ExampleCoroutine()
        {
            yield return new WaitForSeconds(4);
        }
    }
}