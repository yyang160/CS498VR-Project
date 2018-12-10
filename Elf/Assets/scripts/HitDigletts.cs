using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDigletts : MonoBehaviour {
    public GameObject d1, d2, d3, d4, d5, d6;
    public static float countdown = 2.0f;
    public static bool gameEnd = false;

    public static int score;
    public static GameObject[] digletts;
    public static int number;
    public static int prev_number;
    public static GameObject chosen;
    public float smoothTime = 10f;
    private Vector3 speed = Vector3.zero;
    
    public Vector3 pos;
	// Use this for initialization
	void Start () {
        score = 0;
        d1 = GameObject.Find("Diglett1");
        d1.SetActive(false);
        d2 = GameObject.Find("Diglett2");
        d2.SetActive(false);
        d3 = GameObject.Find("Diglett3");
        d3.SetActive(false);
        d4 = GameObject.Find("Diglett4");
        d4.SetActive(false);
        d5 = GameObject.Find("Diglett5");
        d5.SetActive(false);
        d6 = GameObject.Find("Diglett6");
        d6.SetActive(false);
        digletts = new GameObject[] { d1, d2, d3, d4, d5, d6 };
        number = Random.Range(0, digletts.Length);
        chosen = digletts[number];
        pos = this.transform.position;
	}
	

	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;
        
        if (countdown <= 0.0f && !gameEnd)
        {
            //prev_number = number;
            chosen.SetActive(false);
            countdown = 2.0f;
           //escendCountDown = 2.0f;
          number = Random.Range(0, digletts.Length);
            chosen = digletts[number];
            chosen.SetActive(true);
           
        }
        if (gameEnd)
        {
            d1.SetActive(false);
            d2.SetActive(false);
            d3.SetActive(false);
            d4.SetActive(false);
            d5.SetActive(false);
            d6.SetActive(false);
            //.SetActive(false);

        }

    }
}
