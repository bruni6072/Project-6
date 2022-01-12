using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EverythingOff : MonoBehaviour
{
    public GameObject lightsOff;
    public GameObject lightsOnDark;
    public GameObject audiorecording;
    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());

    }
    IEnumerator ExampleCoroutine()
    {

        yield return new WaitForSeconds(4);
        audiorecording.SetActive(true);
        yield return new WaitForSeconds(15);
        lightsOff.SetActive(false);
        lightsOnDark.SetActive(true);
    }
}
