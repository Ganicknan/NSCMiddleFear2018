using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour {
    // Update is called once per frame
    public bool onSwitch;
    public bool lightStatus;
    public GameObject TheLight;

    void OnTriggerEnter(Collider other)
    {
        onSwitch = true;
    }
    void OnTriggerExit(Collider other)
    {
        onSwitch = false;
    }
    void Update()
    {
        if (TheLight.active == true)
        {
            lightStatus = true;
        }
        else
        {
            lightStatus = false;
        }
        if (onSwitch)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (lightStatus)
                {
                    TheLight.active = false;
                }
                else
                {
                    TheLight.active = true;
                }
            }
        }
    }
    void OnGUI()
    {
        if (onSwitch)
        {
            if (lightStatus)
            {
                GUI.Box(new Rect(600, 480, 200, 20), "Prese E to turn off");
            }
            else
            {
                GUI.Box(new Rect(600, 480, 200, 20), "Prese E to turn on");
            }
        }
    }
}
