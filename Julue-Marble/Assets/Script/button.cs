using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {
	GameManager Roll;
	void Start()
	{
		Roll = GameObject.Find("GameManager").GetComponent<GameManager>();
 	}
	public void RollClick()
	{
		Roll.isDiceRoll = true;
		Debug.Log ("Roll");
	}
}
