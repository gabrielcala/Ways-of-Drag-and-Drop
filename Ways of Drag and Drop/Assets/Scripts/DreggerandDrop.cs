using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreggerandDrop : MonoBehaviour
{
    private Vector3 dragOffset;
    private void OnMouseDown()
    {
        dragOffset = transform.position - GetMousePos();
    }
    private void OnMouseDrag()
    {
        transform.position = GetMousePos() + dragOffset;
    }

     Vector3 GetMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}
