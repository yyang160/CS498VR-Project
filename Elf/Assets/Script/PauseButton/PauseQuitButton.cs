using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseQuitButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerStay(Collider other) {
		if(OVRInput.Get(OVRInput.Button.Two) && other.gameObject.tag == "Player"){
			//Debug.Log(collision.gameObject.tag);
			#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
			#else
			Application.Quit();
			#endif
		}
    }
}
