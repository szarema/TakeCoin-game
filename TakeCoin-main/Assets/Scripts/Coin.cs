using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private UIManager UIManager;

    void Start()
    {
        UIManager = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UIManager.CoinUp();
            Destroy(gameObject);
        }
    }
}
