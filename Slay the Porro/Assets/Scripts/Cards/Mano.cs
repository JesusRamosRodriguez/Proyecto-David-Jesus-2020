using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//------------------------------------------------------------------------------------------------------------------------------------------------------
//  Controlador de la mano de cartas.
//------------------------------------------------------------------------------------------------------------------------------------------------------

public class Mano : MonoBehaviour
{
    private List<Card> hand;
    public void AddCardToHand(Card card)
    {
        hand.Add(card);
    }

    public int GetHandSize()
    {
        return hand.Count;
    }
}
