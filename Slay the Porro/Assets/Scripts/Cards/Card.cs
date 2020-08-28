using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using UnityEngine;

using Stats.Card_Stats;
public class Card : MonoBehaviour
{
    [HideInInspector]
    public Vector3 last_pos_card_area;

    [HideInInspector]
    public bool targeteable;
    // Physical - Water - Fire
    [HideInInspector]
    public bool [] dmg_Type = {false, false, false};

    private void Start()
    {
        last_pos_card_area = transform.position;
    }

    //Detecta que una carta ha entrado en el area de combate.
    public void CardOnCombatArea()
    {
        //La carta se suelta y se devuelve a la ultima posicion en el area de cartas.
        GetComponent<DragAndDrop>().SetIsDragging(false);
        last_pos_card_area.z = 0.0f;
        transform.position = last_pos_card_area;
    }
}
