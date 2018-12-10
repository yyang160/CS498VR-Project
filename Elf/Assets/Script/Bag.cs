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

	public static bool Hold = false;
	
	public GameObject MetalBallStatus;
	public GameObject WoodBallStatus;
	public GameObject SoilBallStatus;
	public GameObject WaterBallStatus;
	public GameObject FireBallStatus;

	public Text PokeBallCountObj;
	
	// Use this for initialization
	void Start () {
		//PokeBall.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		PokeBallCountObj.text = PokeBallCount.ToString();

		if(MetalBallCount > 0){
			MetalBallStatus.SetActive(true);
		}

		if(WoodBallCount > 0){
			WoodBallStatus.SetActive(true);
		}

		if(SoilBallCount > 0){
			SoilBallStatus.SetActive(true);
		}

		if(WaterBallCount > 0){
			WaterBallStatus.SetActive(true);
		}

		if(FireBallCount > 0){
			FireBallStatus.SetActive(true);
		}
	}
}
