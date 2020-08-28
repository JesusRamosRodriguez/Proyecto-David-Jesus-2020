using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//------------------------------------------------------------------------------------------------------------------------------------------------------
//  Script de feedback. Al pasar el puntero sobre el elemento contenedor este aumenta su tamaño hasta que se retira.
//------------------------------------------------------------------------------------------------------------------------------------------------------
public class ScaleFeedback : MonoBehaviour
{
    [SerializeField]
    private float scale_factor = 0.1f;
    public void OnMouseEnter()
    {
        transform.localScale += new Vector3(scale_factor, scale_factor, 0);
    }
    public void OnMouseExit()
    {
        transform.localScale -= new Vector3(scale_factor, scale_factor, 0);
    }
}
