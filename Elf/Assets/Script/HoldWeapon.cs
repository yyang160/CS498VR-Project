using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldWeapon : MonoBehaviour {
	
	public float speed = 10;
	public GameObject weapon;
    public Transform hand;
	public static bool IsHoldCrossBow = false;
	public static bool IsEnterCrossBow = false;
	public bool IsHold = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(OVRInput.Get(OVRInput.Button.One)){
			if(!IsHold){
				PickUp();
			}
			else{
				Drop();
			}
		}
		
		if (IsHold && weapon){
            weapon.transform.rotation = hand.rotation; 
			weapon.transform.position = hand.position;
		}
	}
	
	private void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Sword"){
			if(!weapon){
				weapon = other.gameObject;
			}
		}		
		
		if(other.gameObject.tag == "CrossBow"){
			if(!weapon){
				weapon = other.gameObject;
				IsEnterCrossBow = true;
			}
		}
	}
	
	private void OnTriggerExit(Collider other) {
		if(other.gameObject.tag == "Sword"){
			if(!IsHold){
				weapon = null;
			}
		}		
		
		if(other.gameObject.tag == "CrossBow"){
			if(!IsHold){
				weapon = other.gameObject;
				IsEnterCrossBow = false;
			}
		}
	}
	
	
	private void PickUp(){
		weapon.transform.rotation = hand.rotation;
        weapon.transform.position = hand.position;
        weapon.transform.SetParent(hand);
        weapon.GetComponent<Rigidbody>().useGravity = false;
		IsHold = true;
		if(IsEnterCrossBow == true){
			IsHoldCrossBow = true;
		}
    }
	
	private void Drop(){
        weapon.GetComponent<Rigidbody>().useGravity = true;
        weapon.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        weapon.transform.SetParent(null);
        IsHold = false;
		IsHoldCrossBow = false;
    }
}
