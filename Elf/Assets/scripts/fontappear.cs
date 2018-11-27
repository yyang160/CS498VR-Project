using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fontappear : MonoBehaviour {

    public GameObject font;
    public GameObject handle;
    public Collider handlecollider;
    public GameObject indic;
    bool appear;
	// Use this for initialization
	void Start () {
        font = GameObject.Find("Font");
        handle = GameObject.Find("shovelcollider");
        indic = GameObject.Find("fontindicator");
        handlecollider = handle.GetComponent<Collider>();
        font.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        if(appear)
        {
            font.SetActive(true);
        }
		
	}

    private void OnTriggerStay(Collider other)
    {
        if(other == handlecollider)
        {
            appear = true;
            
        }
    }
}
