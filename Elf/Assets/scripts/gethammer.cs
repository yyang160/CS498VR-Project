using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gethammer : MonoBehaviour {
    public GameObject righthand;
    private bool pickhammer;
    public float triggerstate;
    public GameObject ham;
    public Vector3 pos;
    //public GameObject handle;
    private Vector3 oripos;
    private Quaternion orirot;
    // Use this for initialization
    void Start () {
        righthand = GameObject.Find("RightHandAnchor");
        //handcollider = righthand.GetComponent<Collider>();
        ham = GameObject.Find("hammer");
        //handle = GameObject.Find("handle");
        oripos = ham.transform.position;
        orirot = ham.transform.rotation;
        //Debug.Log(this);
    }

    // Update is called once per frame
    void Update () {
        if (pickhammer)
        {
            // pos = righthand.transform.position;
            ham.transform.rotation = righthand.transform.rotation * Quaternion.Euler(0, 70, 0);
            ham.transform.position = righthand.transform.position;
            triggerstate = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
            if (triggerstate > 0.0f)
            {
                pickhammer = false;
                ham.transform.rotation = orirot;
                ham.transform.position = oripos;


            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            triggerstate = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
            if (triggerstate > 0.0f)
            {
                pickhammer = true;

            }
        }
    }
}
