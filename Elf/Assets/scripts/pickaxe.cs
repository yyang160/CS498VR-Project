using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickaxe : MonoBehaviour {
    public GameObject righthand;
    public bool picked;
    public float triggerstate;
    public GameObject axe;
    public Vector3 pos;
    //public GameObject handle;
    public Vector3 oripos;
    public Quaternion orirot;
    // Use this for initialization
    void Start () {
        righthand = GameObject.Find("RightHandAnchor");
        //handcollider = righthand.GetComponent<Collider>();
        axe = GameObject.Find("Pick_Axe");
        //handle = GameObject.Find("handle");
        oripos = axe.transform.position;
        orirot = axe.transform.rotation;
        //Debug.Log(this);
    }
	
	// Update is called once per frame
	void Update () {
        if (picked)
        {
            // pos = righthand.transform.position;
            axe.transform.rotation = righthand.transform.rotation * Quaternion.Euler(0, -270, 0);
            axe.transform.position = righthand.transform.position;
            triggerstate = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
            if (triggerstate > 0.0f)
            {
                picked = false;
                axe.transform.rotation = orirot;
                axe.transform.position = oripos;
        

            }
        }
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log(other);
        if (other.gameObject.tag == "Player")
        {
            triggerstate = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
            if (triggerstate > 0.0f)
            {
                picked = true;

            }
        }
    }
}
