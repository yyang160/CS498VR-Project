using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getgem2 : MonoBehaviour {
    private GameObject bluegem2;
    private GameObject goldgem1;
    private GameObject crystal3;
    private int gemcount;
    private GameObject pickhead;
    private Collider pickcollider;
    private bool pickongem;
    // Use this for initialization
    // Use this for initialization
    void Start () {
        bluegem2 = GameObject.Find("bluegem2");
        goldgem1 = GameObject.Find("goldgem1");
        crystal3 = GameObject.Find("crystal3");
        bluegem2.SetActive(false);
        goldgem1.SetActive(false);
        pickhead = GameObject.Find("pickhead");
        pickcollider = pickhead.GetComponent<Collider>();
        gemcount = 2;
    }
	
	// Update is called once per frame
	void Update () {
        if (pickongem)
        {
            if (gemcount == 1)
            {
                bluegem2.SetActive(true);
            }
            else if (gemcount == 0)
            {
                goldgem1.SetActive(true);
            }
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == pickcollider)
        {
            pickongem = true;
            gemcount -= 1;

        }
    }
}

