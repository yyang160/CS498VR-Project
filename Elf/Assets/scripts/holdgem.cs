using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holdgem : MonoBehaviour {
    public GameObject righthand;
    public bool grabbed;
    public float triggerstate;



    // Use this for initialization
    void Start () {
        righthand = GameObject.Find("RightHandAnchor");

    }

    // Update is called once per frame
    void Update () {
        if (grabbed)
        {
            this.transform.rotation = righthand.transform.rotation;
            this.transform.position = righthand.transform.position;
           
            if (OVRInput.Get(OVRInput.Button.One))
            {
                this.GetComponent<Rigidbody>().useGravity = true;

                grabbed = false;

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
                grabbed = true;

            }
        }

    }

}
