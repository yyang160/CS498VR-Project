using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterelfappear : MonoBehaviour {
    public GameObject vaporeon;
    public Collider ballcollider;
    public GameObject ball;
    public GameObject frozenring;
    bool appear;
	// Use this for initialization
	void Start () {
        vaporeon = GameObject.Find("vapo");
        frozenring = GameObject.Find("frozenring");
        vaporeon.SetActive(false);
        ball = GameObject.Find("waterball");
        ballcollider = ball.GetComponent<Collider>();
        frozenring.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
		if(appear)
        {
            frozenring.SetActive(true);
            vaporeon.SetActive(true);
        }
	}

    private void OnTriggerStay(Collider other)
    {
        if(other == ballcollider)
        {
            // specialeff.setActive(false);
            
            
            appear = true;
        }
    }
}
