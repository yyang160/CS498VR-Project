using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circularmove : MonoBehaviour {
    float timeCounter = 0;
    float speed;
    float width;
    float height;
    float jump;
    public Vector3 pos;
    float count = 5;
    float y;
	// Use this for initialization
	void Start () {
        speed = 1;
        width = 2;
        height = 2;
        jump = 1;
        pos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        y = pos.y;
        timeCounter += Time.deltaTime * speed;
        float x = pos.x +  Mathf.Cos(timeCounter) * width;
        float z = pos.z + Mathf.Sin(timeCounter) * height;
        this.transform.position = new Vector3(x, y, z);
    
        

    }
}
