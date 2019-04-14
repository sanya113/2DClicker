using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyControl : MonoBehaviour // объявляем класс
{
    public float Money = 0; // создаём переменную
    public Text MoneyText;
    public static MoneyControl MoneyScript;
    private void Start()
    {
        MoneyScript = this;
    }
    private void Update()
    {
       MoneyText.text = "Money: " + MoneyScript.Money;
    }
    public static void AddMoney(float Value) // статическа функция, которая добавляет к числу Money
    {
        MoneyScript.Money += Value;
    }
    public static void SubMoney (float Value) // статическая Функция, которая вычитает у Money
    {
        MoneyScript.Money -= Value;
    }
    public static float GetMoney() // Статическая функция, которая возвращает значение Money
    {
        return MoneyScript.Money;
    }
}
