using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour {

    public GameObject fuego1;
    public GameObject fuego2;

    public Transform position1;
    public Transform position2;

    // Use this for initialization
    void Start () {

        StartCoroutine(Example());

		
	}

    IEnumerator Example()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Fuegos Aritifiales 1");
        Instantiate(fuego1, position1);


        yield return new WaitForSeconds(5);
        Debug.Log("Fuegos Aritifiales2");
        Instantiate(fuego2, position2);

    }


    // Update is called once per frame
    void Update () {
		
	}
}
