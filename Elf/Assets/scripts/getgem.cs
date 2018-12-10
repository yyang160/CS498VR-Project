using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getgem : MonoBehaviour {
    private GameObject bluegem1;
    private GameObject greengem1;
    private GameObject redgem1;
    private GameObject crystal1;
    private int gemcount;
    private GameObject pickhead;
    private Collider pickcollider;
    private bool pickongem;

    // Use this for initialization
    void Start () {
        bluegem1 = GameObject.Find("bluegem1");
        greengem1 = GameObject.Find("greengem1");
        redgem1 = GameObject.Find("redgem1");
        crystal1 = GameObject.Find("crystal1");
        bluegem1.SetActive(false);
        greengem1.SetActive(false);
        redgem1.SetActive(false);
        pickhead = GameObject.Find("pickhead");
        pickcollider = pickhead.GetComponent<Collider>();
        gemcount = 3;

	}
	
	// Update is called once per frame
	void Update () {
        if (pickongem)
        {
            if (gemcount == 2)
            {
                bluegem1.SetActive(true);
            }
            else if(gemcount == 1)
            {
                greengem1.SetActive(true);
            }
            else if(gemcount == 0)
            {
                redgem1.SetActive(true);
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
