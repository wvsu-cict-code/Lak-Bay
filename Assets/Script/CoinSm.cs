using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSm : MonoBehaviour
{
    public int coinValue = 1;

    public bool trigger = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(trigger == false)
            {
            ScoreManager.instance.ChangeScore(coinValue);
            }
        }
    }
}
