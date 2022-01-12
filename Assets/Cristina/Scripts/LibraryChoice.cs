using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraryChoice : MonoBehaviour
{

    public GameObject activate_Object;
    public GameObject own_trigger;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "choice")
        {
            activate_Object.SetActive(true);
            own_trigger.SetActive(false);
        }
    }

}
