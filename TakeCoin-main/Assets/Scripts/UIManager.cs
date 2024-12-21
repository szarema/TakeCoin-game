using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text CoinText;
    private int coins = 0;

    void Start()
    {
        CoinText.text = "Coins: " + coins.ToString();
    }

    void Update()
    {
        
    }

    public void CoinUp()
    {
        coins++;
        CoinText.text = "Coins: " + coins.ToString();
    }
}
