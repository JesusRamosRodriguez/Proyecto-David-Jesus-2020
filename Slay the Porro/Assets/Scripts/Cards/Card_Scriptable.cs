using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card_Scriptable : ScriptableObject
{
    public new string name;
    public int id;
    public Sprite background_s;
    public Sprite image_s;
    public Sprite description_s;
    public Sprite type_s;

    public int damage;
}
