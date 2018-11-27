using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour {

    public Transform hand;
	public static bool Hold = false;
	float force = 5f;
	
	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody>().useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Hold){
            this.transform.rotation = hand.rotation; //* Quaternion.Euler(90, 0, 0);
			this.transform.position = hand.position;
			if (Input.GetKeyDown("space") || OVRInput.Get(OVRInput.Button.Two)) { // Button A
				Hold = false;
				this.GetComponent<Rigidbody>().useGravity = true;
				this.GetComponent<Rigidbody>().AddForce(hand.transform.forward.x * force, hand.transform.forward.y * force, hand.transform.forward.z * force, ForceMode.Impulse);
				//this.GetComponent<Rigidbody>().AddForce(hand.transform.forward);
			}
		}
	}
	
	/**private void OnCollisionStay(Collision other) {
		Debug.Log("collision");
        if (Input.GetKeyDown("tab") || OVRInput.Get(OVRInput.Button.One)) { // Button B
			Hold = true;
			Pickup();
        }
    } */
	
	private void OnTriggerStay(Collider other) {
		Debug.Log("collision");
        if (Input.GetKeyDown("tab") || OVRInput.Get(OVRInput.Button.One)) { // Button B
			Hold = true;
			Pickup();
        }
    }
	
	private void Pickup(){
		this.transform.rotation = hand.rotation; // * Quaternion.Euler(90, 0, 0);
        this.transform.position = hand.position;
        this.transform.SetParent(hand);
        this.GetComponent<Rigidbody>().useGravity = false;
    }
}
