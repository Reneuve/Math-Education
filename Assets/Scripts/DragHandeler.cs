using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    public static Vector3 startPosition;
    public static Transform startParent;
    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = gameObject.transform.position;
        startParent = gameObject.transform.parent;
        gameObject.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject panel = GameObject.Find("Bottom Panel");
        panel.transform.SetAsFirstSibling();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        GameObject panel = GameObject.Find("Bottom Panel");
        panel.transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        gameObject.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        gameObject.GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (gameObject.transform.parent == startParent)
        {
            gameObject.transform.position = startPosition;
        }

    }
}
