using UnityEngine;

namespace Game
{
    public class ParticleDestroy : MonoBehaviour
    {
        void Start()
        {
            Invoke ("Destruction", 2f);
        }

        void Destruction()
        {
            Destroy(gameObject);
        }
    }
}

