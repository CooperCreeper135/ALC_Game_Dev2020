using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appe : MonoBehaviour
{
    public new GameObject gameObject;
    public static bool first = true;
    void Start()
    {
        StartCoroutine(RemoveAfterSeconds(3, gameObject));
    }
    IEnumerator RemoveAfterSeconds(int seconds, GameObject image)
    {
        if (first == true)
        {
            yield return new WaitForSeconds(3);
            first = false;
            image.SetActive(false);


        }
        if (first == false)
        {
            
            image.SetActive(false);
        }


    }

}
