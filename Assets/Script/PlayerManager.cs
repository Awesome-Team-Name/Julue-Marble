using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    /*
     * [ 변수 ]
     * 현재 밟고 있는 타일
     */
    private GameObject presentTile; // 현재 밟고 있는 타일

    /* 
     * [ 함수 ]
    // * 현재 타일 판별
     * 각 타일 기능 수행
     * 주사위에 따라 이동
     */     

	// Use this for initialization
	void Start () {
        presentTile = GameObject.Find("tile1_1");
        transform.position = new Vector3(presentTile.transform.position.x, presentTile.transform.position.y + 0.5f, presentTile.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
