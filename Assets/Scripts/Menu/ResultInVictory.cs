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
    private StreamWriter sw;

    String line;
    
    void Start()
    {
        money_counter = Money.GetComponent<MoneyDisplay>().value;
        
        if (!File.Exists(savePath))
        {
            sw = new StreamWriter(savePath);
        }
        
        StreamReader sr = new StreamReader(savePath);
        // Считаем количество чисел.
        int n = File.ReadAllLines(savePath).Length;
        if (n == 0)
        {
            Debug.Log("Новый рекорд: " + money_counter);
        }
        else
        {
            int maxResult = 0;
            //Поиск максимального значения
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(sr.ReadLine());
                if (maxResult < value ) maxResult = value;
            }
            //Сравнение нового результата с максимальным результом
            if (maxResult > money_counter)
            {
                Debug.Log("Новый рекорд: " + money_counter);
            }
        }
        sr.Close();
        
        //Запись результата в конец файла
        using (StreamWriter writer = new StreamWriter(savePath, true))
        {
            _text.text = money_counter.ToString();
            writer.WriteLineAsync(_text.text);
        }
        sw.Close();
    }
}
