using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Mano mano;

    private void init()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    private void Awake()
    {
        init();
    }
    public void CardAdded(int id, Card card)
    {
        mano.AddCardToHand(id, card);
    }
}
