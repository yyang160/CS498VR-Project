using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodBallButton : MonoBehaviour {

	public GameObject WoodBall;
	public Transform hand;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerStay(Collider other) {
		if(Bag.Hold == false && Bag.WoodBallCount > 0 && OVRInput.Get(OVRInput.Button.Two) && other.gameObject.tag == "Player"){
			WoodBall.SetActive(true);
			Bag.WoodBallHold = true;
		 	WoodBall.transform.rotation = hand.rotation;
			WoodBall.transform.position = hand.position;
		}
    }
}
