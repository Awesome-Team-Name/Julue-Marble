using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private PlayerManager pm;

    private GameObject dice1, dice2;

    private int dice1_value = 0;
    private int dice2_value = 0;

    public bool isDiceRoll = true;

    private void Start()
    {
        pm = GameObject.Find("Player").GetComponent<PlayerManager>();

        dice1 = GameObject.Find("Dice1");
        dice2 = GameObject.Find("Dice2");
    }

    void Update()
    {
        if (isDiceRoll == true)
        {
            updateDice();
            pm.playerMove(dice1_value + dice2_value);

            isDiceRoll = false;
        }
    }

    // dice의 value 받아오기
    private void updateDice()
    {
        dice1_value = dice1.GetComponent<Die_d6>().getValue();
        dice2_value = dice2.GetComponent<Die_d6>().getValue();
    }
    
    // get
    public int getDiceValue(int choice)
    {
        int returnValue = 0;

        switch(choice)
        {
            case 1:
                returnValue = dice1_value;
                break;

            case 2:
                returnValue = dice2_value;
                break;

            default:
                break;                
        }

        return returnValue;
    }
}
