using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeBallButton : MonoBehaviour {

	public GameObject PokeBall;
	public Transform hand;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerStay(Collider other) {
		if(Bag.Hold == false && Bag.PokeBallCount > 0 && OVRInput.Get(OVRInput.Button.Two) && other.gameObject.tag == "Player"){
			PokeBall.SetActive(true);
			Bag.PokeBallHold = true;
		 	PokeBall.transform.rotation = hand.rotation;
			PokeBall.transform.position = hand.position;
			Bag.PokeBallCount -= 1;
		}
    }
}
