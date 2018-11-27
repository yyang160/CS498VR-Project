using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab_all : MonoBehaviour {
    public GameObject righthand;
    public bool pressed;
    public float triggerstate;
    public GameObject shovel;
    public Vector3 pos;
    public GameObject handle;
    public Vector3 oripos;
    public Quaternion orirot;
    //public Collider handcollider;

	// Use this for initialization
	void Start () {
        righthand = GameObject.Find("RightHandAnchor");
        //handcollider = righthand.GetComponent<Collider>();
        shovel = GameObject.Find("shovel");
        handle = GameObject.Find("handle");
        oripos = handle.transform.position;
        orirot = handle.transform.rotation;
        Debug.Log(this);


    }

    // Update is called once per frame
    void Update () {
		if(pressed)
        {
            // pos = righthand.transform.position;
            handle.transform.rotation = righthand.transform.rotation * Quaternion.Euler(-90, 0, 0);
            handle.transform.position = righthand.transform.position;
            triggerstate = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
            if (triggerstate > 0.0f)
            {
                pressed = false;
                handle.transform.rotation = orirot;
                handle.transform.position = oripos;


            }
        }
	}

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            triggerstate = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
            if (triggerstate > 0.0f)
            {
                pressed = true;

            }
        }
    }
}
