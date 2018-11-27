using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchscroll : MonoBehaviour {
    public GameObject expandedScroll;
    public GameObject info;
    public GameObject originalScroll;
    public float triggerstate;
    public bool pressed;

    // Use this for initialization
    void Start () {
        expandedScroll = GameObject.Find("expandscroll");
        expandedScroll.SetActive(false);
        info = GameObject.Find("Exclamation_Yellow");
        originalScroll = GameObject.Find("scroll");
    }
	
	// Update is called once per frame
	void Update () {
        if (pressed)
        {
            Destroy(info);
            originalScroll.SetActive(false);
            expandedScroll.SetActive(true);
        }
	}

    void OnTriggerStay(Collider other)
    {

        triggerstate = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
        if (triggerstate > 0.0f)
        {
            pressed = true;
        }
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("enter");

            pressed = true;
        }
    }
    
}
