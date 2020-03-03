using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appe : MonoBehaviour
{
    public GameObject gameObject;

    void Start()
    {
        StartCoroutine(RemoveAfterSeconds(3, gameObject));
    }
    IEnumerator RemoveAfterSeconds(int seconds, GameObject image)
    {
        yield return new WaitForSeconds(3);
        image.SetActive(false);
    }

}
