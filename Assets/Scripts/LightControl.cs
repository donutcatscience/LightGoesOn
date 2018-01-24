using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour {
    private Light myLight;
    public bool lightState = true;


	// Use this for initialization
	void Start () {
        myLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && lightState == true)
        {
            myLight.enabled = false;
            lightState = false;
        } else if (Input.GetKeyDown(KeyCode.Space) && lightState == false)
        {
            myLight.enabled = true;
            lightState = true;
        }
	}
}
