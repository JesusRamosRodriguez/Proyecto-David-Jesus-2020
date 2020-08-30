using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//------------------------------------------------------------------------------------------------------------------------------------------------------
//  Controlador de la mano de cartas.
//------------------------------------------------------------------------------------------------------------------------------------------------------

public class Mano : MonoBehaviour
{
    private Dictionary<int, Card> hand = new Dictionary<int, Card>(); 
    public void AddCardToHand(int id, Card card)
    {
        hand.Add(id, card);
        Debug.Log("New card added with ID: " + id);
        Debug.Log("Mano size = " + hand.Count);
    }

    public Card GetCardFromId (int id)
    {
        return hand[id];
    }
    public int GetHandSize()
    {
        return hand.Count;
    }
}
