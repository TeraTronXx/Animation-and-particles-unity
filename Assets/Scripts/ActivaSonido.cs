using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivaSonido : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Camara")
        {
            GetComponent<AudioSource>().Play();
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Camara")
        {
            GetComponent<AudioSource>().Stop();

        }
    }
}
