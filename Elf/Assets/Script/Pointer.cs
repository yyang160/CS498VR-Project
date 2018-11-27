using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour {

	public Transform hand;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
        if(Physics.Raycast(hand.transform.position, hand.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
			if(hit.collider.tag == "PokeBallButton"){
				Debug.Log("Did Hit");
				Debug.DrawRay(hand.transform.position, hand.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
				if(OVRInput.Get(OVRInput.Button.Two)){
					Bag.PokeBallHold = true;
				}
			}
        }
		else
        {
            Debug.DrawRay(hand.transform.position, hand.transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            //Debug.Log("Did not Hit");
        }
	}
}
