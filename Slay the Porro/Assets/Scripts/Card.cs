using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using UnityEngine;

using Stats.Card_Stats;
public class Card : MonoBehaviour
{
    [HideInInspector]
    public bool targeteable;
    // Physical - Water - Fire
    [HideInInspector]
    public bool [] dmg_Type = {false, false, false};
}
