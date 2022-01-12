using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEverything : MonoBehaviour
{
    public GameObject everything;
    
    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());

    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        everything.SetActive(true);
       
    }
}
