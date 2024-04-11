using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyManager : MonoBehaviour
{
    public double currentMoney = 0;
    public TextMeshProUGUI CurrencyText;

    void displayMoney()
    {
        CurrencyText.text = "$" + currentMoney.ToString("F2");
    }

    private void Update()
    {
        displayMoney();
    }
}
