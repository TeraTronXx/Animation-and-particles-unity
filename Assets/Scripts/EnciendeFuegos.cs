using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnciendeFuegos : MonoBehaviour {

    public ParticleSystem ps1; //variables para las dos particulas de los fuegos aritificales.
    public ParticleSystem ps2;


    // Use this for initialization
    void Start () {

        StartCoroutine(Example());

	}

    IEnumerator Example()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Fuegos Aritifiales 1");
        ps1.Play();

        yield return new WaitForSeconds(5);
        Debug.Log("Fuegos Aritifiales2");
        ps2.Play();
        ps1.Stop();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
