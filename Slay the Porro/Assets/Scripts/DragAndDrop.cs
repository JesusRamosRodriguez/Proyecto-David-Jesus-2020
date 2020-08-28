using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//------------------------------------------------------------------------------------------------------------------------------------------------------
//  Script que permite arrastrar y soltar cartas.
//------------------------------------------------------------------------------------------------------------------------------------------------------

public class DragAndDrop : MonoBehaviour
{
    private bool isDragging;

    public void OnMouseDown()
    {
        isDragging = true;
        GetComponent<Card>().last_pos_card_area = transform.position;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    public void SetIsDragging (bool status)
    {
        isDragging = status;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}
