using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class f1 : MonoBehaviour ,IPointerEnterHandler, IPointerExitHandler
{
    public GameObject eOne;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        //do your stuff when highlighted
        eOne.SetActive(true);
        Debug.Log("true");
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        eOne.SetActive(false);
        Debug.Log("false");
    }
}

