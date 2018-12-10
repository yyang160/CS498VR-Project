using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalBallButton : MonoBehaviour {

	public GameObject MetalBall;
	public Transform hand;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerStay(Collider other) {
		if(Bag.Hold == false && Bag.MetalBallCount > 0 && OVRInput.Get(OVRInput.Button.Two) && other.gameObject.tag == "Player"){
			MetalBall.SetActive(true);
			Bag.MetalBallHold = true;
		 	MetalBall.transform.rotation = hand.rotation;
			MetalBall.transform.position = hand.position;
		}
	}
}
