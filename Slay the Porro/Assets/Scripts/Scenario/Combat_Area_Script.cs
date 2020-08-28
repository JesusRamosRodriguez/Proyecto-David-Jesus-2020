﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat_Area_Script : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Card"))
            collision.gameObject.GetComponent<Card>().CardOnCombatArea();

    }

}
