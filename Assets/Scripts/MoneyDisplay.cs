using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class MoneyDisplay : MonoBehaviour
    {
        public int value = 0;
        public Text _money;

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
            value++;
            _money.text = $"{value}";
        }
    }
}
