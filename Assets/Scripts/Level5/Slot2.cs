using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot2 : MonoBehaviour, IDropHandler
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
            //game object adalah slot answer
            GameObject clone = Instantiate(DragHandeler.itemBeingDragged);
            clone.transform.SetParent(DragHandeler.startParent);
            clone.transform.localScale = DragHandeler.itemBeingDragged.transform.localScale;
            clone.name = DragHandeler.itemBeingDragged.name;
            clone.GetComponent<CanvasGroup>().blocksRaycasts = true;
            // dupObject.transform.SetParent(DragHandeler.startParent.transform);
            DragHandeler.itemBeingDragged.transform.SetParent(gameObject.transform); //jika item tidak ada (null)                                                                                     
        }
    }
}
