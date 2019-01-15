using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.XR;


public class MueveCamara : MonoBehaviour {

    Vector3 lastMouse = new Vector3(255, 255, 255);

    [Range(0f, 1f)]
    public float camSens = 0.5f;

    float speedHori= 10.0f;
    float speedVert= 10.0f;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        CameraPosition();

        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translationV = Input.GetAxis("Vertical") * speedVert;
        float translationH = Input.GetAxis("Horizontal") * speedHori;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translationV *= Time.deltaTime;
        translationH *= Time.deltaTime;

        // Move translation along the object's x-axis
        transform.Translate(translationH, 0, 0);
        // Rotate around our y-axis
        transform.Translate(0, 0, translationV);


        /*float xAxisValue = Input.GetAxis("Horizontal");
        float zAxisValue = Input.GetAxis("Vertical");
        if (Camera.current != null)
        {
            Camera.current.transform.Translate(new Vector3(xAxisValue, 0.0f, zAxisValue));
        }*/


    }


    void CameraPosition()
    {
        if (!XRSettings.enabled)
        {


            Vector3 deltaMouse = Input.mousePosition - lastMouse;
            deltaMouse = deltaMouse * camSens;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x - deltaMouse.y, transform.eulerAngles.y + deltaMouse.x, 0);
            lastMouse = Input.mousePosition;
        }
    }
}
