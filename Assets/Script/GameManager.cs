using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private GameObject dice1, dice2;

    private int dice1_value = 0;
    private int dice2_value = 0;

    private void Start()
    {
        dice1 = GameObject.Find("Dice1");
        dice2 = GameObject.Find("Dice2");
    }

    void Update()
    {
        updateDice();
    }

    // dice의 value 받아오기
    private void updateDice()
    {
        dice1_value = dice1.GetComponent<Die_d6>().getValue();
        dice2_value = dice2.GetComponent<Die_d6>().getValue();

        Debug.Log("dice1 : " + dice1_value + "dice2 : " + dice2_value);
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
