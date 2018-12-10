using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class digletts : MonoBehaviour {
    // Use this for initialization
    public GameObject trigletts;
    public GameObject hamm;
    private Collider hcollider;
    private bool hit;
	void Start () {
        trigletts.SetActive(false);
        hit = false;
        hamm = GameObject.Find("hammer");
        hcollider = hamm.GetComponent<Collider>();
        
    }

    // Update is called once per frame
    void Update () {
        if(hit)
        {
            HitDigletts.score++;
            hit = false;
        }
        if (HitDigletts.score == 3)
        {
            HitDigletts.gameEnd = true;
            trigletts.SetActive(true);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger:", other);
        if(other == hcollider)
        {
            hit = true;
        }
       
    }
}
