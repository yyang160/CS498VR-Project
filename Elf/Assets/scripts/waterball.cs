using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterball : MonoBehaviour {

    public GameObject ball;
    float triggerstate;
    public bool getball;
    public GameObject righthand;
	// Use this for initialization
	void Start () {
        ball = GameObject.Find("waterball");
        ball.SetActive(false);
        righthand = GameObject.Find("RightHandAnchor");

    }

    // Update is called once per frame
    void Update () {
		if(getball)
        {
            ball.transform.rotation = righthand.transform.rotation ;
            ball.transform.position = righthand.transform.position;
            triggerstate = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
            if (triggerstate > 0.0f)
            {
                ball.GetComponent<Rigidbody>().useGravity = true;

                getball = false ;

            }
        }
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ball.SetActive(true);
            getball = true;
        }
    }
}
