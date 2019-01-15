using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaNave : MonoBehaviour {

    public GameObject Nave;

    public Transform posicion;
    public Transform posicion2;
    public Transform posicion3;

    // Use this for initialization
    void Start () {
        StartCoroutine(Spaceship());
	}


    IEnumerator Spaceship()
    {
        float x = Random.Range(-10, 10);
        float y = Random.Range(-10, 10);
        float z = Random.Range(-10, 10);
        posicion.position = new Vector3(x, y, z);

        yield return new WaitForSeconds(2);
        Debug.Log("Fuegos Aritifiales 1");
        Instantiate(Nave, posicion);

        x = Random.Range(-10, 10);
        y = Random.Range(-10, 10);
        z = Random.Range(-10, 10);
        posicion2.position = new Vector3(x, y, z);

        yield return new WaitForSeconds(2);
        Debug.Log("Fuegos Aritifiales 2");
        Instantiate(Nave, posicion2);

        x = Random.Range(-10, 10);
        y = Random.Range(-10, 10);
        z = Random.Range(-10, 10);
        posicion3.position = new Vector3(x, y, z);

        yield return new WaitForSeconds(2);
        Debug.Log("Fuegos Aritifiales 3");
        Instantiate(Nave, posicion3);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
