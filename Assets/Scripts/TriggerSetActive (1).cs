using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sam Robichaud NSCC

public class TriggerSetActive : MonoBehaviour
{ 
    public GameObject targetObject;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
         targetObject.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
         targetObject.SetActive(true);
        }
    }       
}
