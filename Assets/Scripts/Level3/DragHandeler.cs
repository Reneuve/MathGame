using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandeler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    public static Vector3 startPosition;
    public static Transform startParent;
    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        gameObject.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == startParent)
        {
            transform.position = startPosition;
        }
    }
}
