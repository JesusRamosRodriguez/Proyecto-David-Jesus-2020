using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card_Scriptable : ScriptableObject
{
    public string card_name;
    public Sprite background_s;
    public Sprite image_s;
    public Sprite description_s;
    public Sprite type_s;

    public int damage;
}
