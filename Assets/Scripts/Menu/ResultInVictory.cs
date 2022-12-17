using System;
using System.IO;
using Game;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ResultInVictory : MonoBehaviour
{
    public string savePath = "Result.ga";

    [SerializeField] private GameObject Money;
    [SerializeField] private Text _text;
    private int money_counter;
    
    void Start()
    {
        money_counter = Money.GetComponent<MoneyDisplay>().value;
        _text.text = "Result: " + money_counter;
        /*if (!File.Exists(savePath))
        {
            var sw = new StreamWriter(savePath);
        }
        else
        {
            var sw = new StreamReader(savePath);
        }

        sw.WriteLine("222");
        
        Debug.Log("Сохранил результат в фаил");
        sw.Close();*/
        
    }
}
