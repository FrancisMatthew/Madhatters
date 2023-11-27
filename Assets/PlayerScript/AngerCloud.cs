using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerCloud : MonoBehaviour
{
    public GameObject angerCloudParticles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ledge")
        {
            angerCloudParticles.SetActive(true);
        }    
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ledge")
        {
            angerCloudParticles.SetActive(false);
        }
    }
}
