using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilBallButton : MonoBehaviour {

	public GameObject SoilBall;
	public Transform hand;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerStay(Collider other) {
		if(Bag.Hold == false && Bag.SoilBallCount > 0 && OVRInput.Get(OVRInput.Button.Two) && other.gameObject.tag == "Player"){
			SoilBall.SetActive(true);
			Bag.SoilBallHold = true;
		 	SoilBall.transform.rotation = hand.rotation;
			SoilBall.transform.position = hand.position;
		}
    }
}
