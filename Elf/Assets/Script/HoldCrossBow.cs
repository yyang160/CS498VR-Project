using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldCrossBow : MonoBehaviour {

	public GameObject weapon;
    public Transform hand;
	public static bool IsHoldCrossBow = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (IsHoldCrossBow){
            weapon.transform.rotation = hand.rotation; //* Quaternion.Euler(90, 0, 0);
			weapon.transform.position = hand.position;
		}
	}
	
	private void OnTriggerStay(Collider other) {
		//Debug.Log(other.gameObject.tag);
        if (!Bag.Hold && !IsHoldCrossBow && other.gameObject.tag == "Player"){
			if(OVRInput.Get(OVRInput.Button.Two)){ // Button B
				IsHoldCrossBow = true;
				Pickup();
			}
        }
    }
	
	private void Pickup(){
		weapon.transform.rotation = hand.rotation; // * Quaternion.Euler(90, 0, 0);
        weapon.transform.position = hand.position;
        weapon.transform.SetParent(hand);
        weapon.GetComponent<Rigidbody>().useGravity = false;
    }
}
