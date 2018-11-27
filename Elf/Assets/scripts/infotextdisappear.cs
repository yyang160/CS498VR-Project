using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infotextdisappear : MonoBehaviour {
    public float time = 20;
	// Use this for initialization
	IEnumerator Start () {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
