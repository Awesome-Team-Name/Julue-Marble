using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceTextManager : MonoBehaviour {
    private GameManager gm;

    public GUIText diceText;

	// Use this for initialization
	void Start () {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        int dice1_value, dice2_value;

        dice1_value = gm.getDiceValue(1);
        dice2_value = gm.getDiceValue(2);

        diceText.text = "주사위 1 : " + dice1_value + "\n주사위 2 : " + dice2_value;
	}
}
