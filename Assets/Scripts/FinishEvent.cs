using UnityEngine;

namespace Game
{
    public class FinishEvent : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip soundAddGold;
        
        void Start()
        {
            audioSource.PlayOneShot(soundAddGold);
        }

    }

}
