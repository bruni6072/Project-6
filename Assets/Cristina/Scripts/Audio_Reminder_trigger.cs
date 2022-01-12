using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Reminder_trigger : MonoBehaviour
{
    public GameObject whatToDO;
    public GameObject reminder;
    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());

    }
    IEnumerator ExampleCoroutine()
    {
        
        yield return new WaitForSeconds(4);
        whatToDO.SetActive(true);
        yield return new WaitForSeconds(10);
        reminder.SetActive(true);
    }
}
