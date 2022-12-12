using Game;
using UnityEngine;
using UnityEngine.UI;

public class ResultInVictory : MonoBehaviour
{ 
    [SerializeField] private GameObject Money;
    [SerializeField] private Text _text;
    private int money_counter;
    
    void Update()
    {
        money_counter = Money.GetComponent<MoneyDisplay>().value;
        _text.text = "Result: " + money_counter.ToString();
    }
}
