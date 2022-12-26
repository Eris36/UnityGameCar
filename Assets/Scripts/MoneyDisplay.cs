using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class MoneyDisplay : MonoBehaviour
    {
        public int value = 0;
        public Text _money;
        
        public AudioSource audioSource;
        public AudioClip soundAddGold;

        private void OnEnable()
        {
            MonyDelete._addMoney += AddValue;
        }
        
        private void OnDisable()
        {
            MonyDelete._addMoney -= AddValue;
        }
        
        public void AddValue()
        {
            audioSource.PlayOneShot(soundAddGold);
            value++;
            _money.text = $"Gold:{value}";
        }
    }
}
