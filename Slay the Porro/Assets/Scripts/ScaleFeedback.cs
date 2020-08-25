using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFeedback : MonoBehaviour
{
    public void OnMouseEnter()
    {
        transform.localScale += new Vector3(0.1f, 0.1f, 0);
    }

    public void OnMouseOver()
    {
    }

    public void OnMouseExit()
    {
        transform.localScale -= new Vector3(0.1f, 0.1f, 0);
    }
}
