using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using UnityEngine.UI;


public class Bag : MonoBehaviour {

	public static int PokeBallCount = 10;
	public static int MetalBallCount = 0;
	public static int WoodBallCount = 0;
	public static int SoilBallCount = 0;
	public static int WaterBallCount = 0;
	public static int FireBallCount = 0;
	
	public static bool PokeBallHold = false;
	public static bool MetalBallHold = false;
	public static bool WoodBallHold = false;
	public static bool SoilBallHold = false;
	public static bool WaterBallHold = false;
	public static bool FireBallHold = false;
	
	public GameObject PokeBall;
	public GameObject MetalBall;
	public GameObject WoodBall;
	public GameObject SoilBall;
	public GameObject WaterBall;
	public GameObject FireBall;
	
	//public Text countObj;
	
	public Transform hand;
	
	// Use this for initialization
	void Start () {
		//PokeBall.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		//countObj.text = "0";
		
		if(PokeBallHold){
			PokeBall.SetActive(true);
			PokeBall.transform.rotation = hand.rotation;
			PokeBall.transform.position = hand.position;
		}
	}
}
