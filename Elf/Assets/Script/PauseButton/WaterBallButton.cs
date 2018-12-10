using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBallButton : MonoBehaviour {

	public GameObject WaterBall;
	public Transform hand;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerStay(Collider other) {
		if(Bag.Hold == false && Bag.WaterBallCount > 0 && OVRInput.Get(OVRInput.Button.Two) && other.gameObject.tag == "Player"){
			WaterBall.SetActive(true);
			Bag.WaterBallHold = true;
		 	WaterBall.transform.rotation = hand.rotation;
			WaterBall.transform.position = hand.position;
		}
    }
}
