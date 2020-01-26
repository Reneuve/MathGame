using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public GameObject item
    {
        get
        {
            Debug.Log(gameObject.transform.childCount);
            if (gameObject.transform.childCount > 0)
            {
                return gameObject.transform.GetChild(0).gameObject; //jika ada isinya
            }
            return null; //jika tidak ada isinya
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            DragHandeler.itemBeingDragged.transform.SetParent(gameObject.transform); //jika item tidak ada (null)
        }
    }
}
