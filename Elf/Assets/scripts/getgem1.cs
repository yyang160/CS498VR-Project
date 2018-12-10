using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getgem1 : MonoBehaviour {
    private GameObject bluegem3;
    private GameObject greengem2;
    private GameObject goldgem2;
    private GameObject crystal2;
    private int gemcount;
    private GameObject pickhead;
    private Collider pickcollider;
    private bool pickongem;
    // Use this for initialization
    void Start () {
        bluegem3 = GameObject.Find("bluegem3");
        greengem2 = GameObject.Find("greengem2");
        goldgem2 = GameObject.Find("goldgem2");
        crystal2 = GameObject.Find("crystal2");
        bluegem3.SetActive(false);
        greengem2.SetActive(false);
        goldgem2.SetActive(false);
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
                bluegem3.SetActive(true);
            }
            else if (gemcount == 1)
            {
                greengem2.SetActive(true);
            }
            else if (gemcount == 0)
            {
                goldgem2.SetActive(true);
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
