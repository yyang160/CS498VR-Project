using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {
	
	public GameObject WoodElf;
	
	// Use this for initialization
	void Start () {
		WoodElf.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnCollisionEnter(Collision collision) {
		this.GetComponent<Rigidbody>().useGravity = true;
		WoodElf.SetActive(true);
    }
}
