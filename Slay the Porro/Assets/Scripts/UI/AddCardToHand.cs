using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCardToHand : MonoBehaviour
{
    private static GameManager gm;
    public GameObject cardPrefab;
    private int card_id = 0;

    private void Start()
    {
        try
        {
            gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
        catch (System.Exception e)
        {
            Debug.LogError("Fatal error ocurred. AddCardToHand couldn't find the GameManager. \n" + e.Message);
            throw;
        }
        card_id = 0;
    }
    public void SpawnCard()
    {
        GameObject newCard = Instantiate(cardPrefab, new Vector3(-8, -3, 0), Quaternion.identity);
        Card card = newCard.GetComponent<Card>();
        card.id = card_id;
        gm.CardAdded(card_id, card);
        card_id++;
        Debug.Log("New card added to hand! ID: " + newCard.GetComponent<Card>().id);
    }
}
