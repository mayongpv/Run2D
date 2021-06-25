﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        print(collision.transform);
        GetComponentInChildren<Animator>().Play("Hide", 1);
        RunGameManager.instance.AddCoin(100);
    }
}
