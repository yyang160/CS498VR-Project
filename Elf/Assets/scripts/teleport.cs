using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {

    public GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("OVRPlayerController");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (OVRInput.Get(OVRInput.Button.One))
            {
                player.transform.position = new Vector3(-63f, 3.619f, 11f);
            }
        }
    }
}
