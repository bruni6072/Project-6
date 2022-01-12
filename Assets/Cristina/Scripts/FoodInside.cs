using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInside : MonoBehaviour
{
    public GameObject activate_Protein;
    public GameObject active_Veg;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Table_Veg")
        {
            activate_Protein.SetActive(true);
            active_Veg.SetActive(true);
           
        }
    }
}
