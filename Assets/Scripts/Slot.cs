using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Slot : MonoBehaviour, IDropHandler
{
    AudioSource soundClick;
    public GameObject item
    {
        get
        {
            if (gameObject.transform.childCount > 0)
            {
                return gameObject.transform.GetChild(0).gameObject;
            }
            else
            {
                return null;
            }
        }
    }
    public void OnDrop(PointerEventData eventData)
    {
        soundClick = gameObject.GetComponent<AudioSource>();
        if (item == null)
        {
            DragHandeler.itemBeingDragged.transform.SetParent(gameObject.transform);
        }
        soundClick.Play();
    }
}
