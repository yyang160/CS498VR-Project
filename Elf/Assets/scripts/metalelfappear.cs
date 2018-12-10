using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metalelfappear : MonoBehaviour {
    public GameObject metalmon;
    public MeshCollider gemcollider1;
    public MeshCollider gemcollider2;
    public GameObject gem1;
    public GameObject gem2;
    //blic GameObject greenring;
    private bool appear;
    // Use this for initialization
    void Start () {
        metalmon = GameObject.Find("Guardromon");
        //eenring = GameObject.Find("frozenring");
        appear = false;
        metalmon.SetActive(false);

        //gem1= GameObject.Find("goldgem1");
        //gem2 = GameObject.Find("goldgem2");
        gemcollider1 = gem1.GetComponent<MeshCollider>();
        Debug.Log("gem1:", gem1);
        Debug.Log(gemcollider1);

        gemcollider2 = gem2.GetComponent<MeshCollider>();
       
        //ozenring.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (appear)
        {
            //ozenring.SetActive(true);
            //Debug.Log("appear");
            metalmon.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (other == gemcollider1|| other == gemcollider2)
        //if (other == gemcollider1)
        {
            // specialeff.setActive(false);
            Debug.Log("in");
            appear = true;
        }
    }
}
