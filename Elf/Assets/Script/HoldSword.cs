using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldSword : MonoBehaviour {

	public float speed = 10;
	public GameObject weapon;
    public Transform hand;
	public static bool IsHoldSword = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (IsHoldSword){
            weapon.transform.rotation = hand.rotation; //* Quaternion.Euler(90, 0, 0);
			weapon.transform.position = hand.position;
		}
		
		if(IsHoldSword && OVRInput.Get(OVRInput.Button.One)){
			Debug.Log("D");
			Drop();
		}
	}
	
	private void OnTriggerStay(Collider other) {
        if (OVRInput.Get(OVRInput.Button.Two) && !IsHoldSword && other.gameObject.tag == "Player") { // Button B
			IsHoldSword = true;
			Pickup();
        }
    }
	
	private void Pickup(){
		weapon.transform.rotation = hand.rotation; // * Quaternion.Euler(90, 0, 0);
        weapon.transform.position = hand.position;
        weapon.transform.SetParent(hand);
        weapon.GetComponent<Rigidbody>().useGravity = false;
    }
	
	private void Drop(){
        weapon.GetComponent<Rigidbody>().useGravity = true;
        weapon.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        weapon.transform.SetParent(null);
        IsHoldSword = false;
    }
}
