using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	public GameObject PauseMenu;
	public GameObject PauseOne;
	public GameObject PauseTwo;
	public GameObject PauseThree;
	
	public Transform Player;
	public static bool IsPause = false;

	// Use this for initialization
	void Start () {
		PauseMenu.SetActive(false);
		PauseOne.SetActive(false);
		PauseTwo.SetActive(false);
		PauseThree.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("tab")){
			if(!IsPause){
				IsPause = true;
				PauseMenu.SetActive(true);
				PauseMenu.transform.position = Player.position + 3 * Player.forward + new Vector3(0, 2, 0)/3;
				PauseMenu.transform.rotation = Player.rotation * Quaternion.Euler(0, 180, 0);
				
				PauseOne.SetActive(true);
				PauseOne.transform.position = Player.position + 2 * Player.right + 1 * Player.forward + new Vector3(0, 2, 0)/3;
				PauseOne.transform.rotation = Player.rotation * Quaternion.Euler(0, -90, 0);
				PauseOne.GetComponent<Renderer>().enabled = false;
				
				PauseTwo.SetActive(true);
				PauseTwo.transform.position = Player.position - 2 * Player.right + 1 * Player.forward + new Vector3(0, 2, 0)/3;
				PauseTwo.transform.rotation = Player.rotation * Quaternion.Euler(0, 90, 0);
				PauseTwo.GetComponent<Renderer>().enabled = false;
				
				PauseThree.SetActive(true);
				PauseThree.transform.position = Player.position - 1 * Player.forward + new Vector3(0, 2, 0)/3;
				PauseThree.transform.rotation = Player.rotation * Quaternion.Euler(0, -180, 0);
				PauseThree.GetComponent<Renderer>().enabled = false;
			}
			else{
				IsPause = false;
				PauseMenu.SetActive(false);
				PauseOne.SetActive(false);
				PauseTwo.SetActive(false);
				PauseThree.SetActive(false);
			}
		}
	}
}
