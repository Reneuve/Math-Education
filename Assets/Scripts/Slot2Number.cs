﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Slot2Number : MonoBehaviour, IDropHandler
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
        GameObject gameObjectClone = Instantiate(DragHandeler.itemBeingDragged);
        soundClick = gameObject.GetComponent<AudioSource>();
        if (item == null)
        {
            gameObjectClone.transform.SetParent(DragHandeler.startParent);
            gameObjectClone.transform.localScale = DragHandeler.itemBeingDragged.transform.localScale;
            gameObjectClone.GetComponent<CanvasGroup>().blocksRaycasts = true;
            gameObjectClone.name = DragHandeler.itemBeingDragged.name;
            DragHandeler.itemBeingDragged.transform.SetParent(gameObject.transform);
        }
        soundClick.Play();
    }
}
