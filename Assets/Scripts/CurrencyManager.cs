using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyManager : MonoBehaviour
{
    public float currentMoney = 0;
    public TextMeshProUGUI CurrencyText;

    private void Update()
    {
        CurrencyText.text = "Rp " + CurrencyFormat();
    }

    public string CurrencyFormat()
    {   
        string[] suffix = { "", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion", "Sextillion", "Septillion", "Octillion", "Nonillion", "Decillion", "Undecillion", "Duodecillion", "Tredecillion", "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septendecillion", "Octodecillion", "Novemdecillion", "Vigintillion", "Unvigintillion", "Duovigintillion", "Tresvigintillion", "Quattuorvigintillion", "Quinquavigintillion", "Sesvigintillion", "Septemvigintillion", "Octovigintillion", "Novemvigintillion", "Trigintillion", "Duotrigintillion" };
        int i=0;
        double amount = currentMoney;
        for(i=0; amount >= 1000; i++)
        {
            amount /= 1000;
        }

        return amount.ToString("F2") + " " + suffix[i];
    }
}
