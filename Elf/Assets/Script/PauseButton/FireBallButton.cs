using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallButton : MonoBehaviour {

	public GameObject FireBall;
	public Transform hand;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerStay(Collider other) {
		if(Bag.Hold == false && Bag.FireBallCount > 0 && OVRInput.Get(OVRInput.Button.Two) && other.gameObject.tag == "Player"){
			FireBall.SetActive(true);
			Bag.FireBallHold = true;
		 	FireBall.transform.rotation = hand.rotation;
			FireBall.transform.position = hand.position;
		}
    }
}
