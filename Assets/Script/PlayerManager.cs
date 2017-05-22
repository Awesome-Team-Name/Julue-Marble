using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    /*
     * [ 변수 ]
     * 현재 밟고 있는 타일 (O)
     */
    private GameObject presentTile; // 현재 밟고 있는 타일

    /* 
     * [ 함수 ]
    // * 현재 타일 판별
     * 각 타일 기능 수행
     * 주사위에 따라 이동
     */     

    // 받아온 주사위 값에 따라 player 이동
    public void playerMove(int dice_value)
    {
        for (int i = 0; i < dice_value; i++)
        {
            // next tile 찾기
            presentTile = presentTile.GetComponent<TileManager>().nextTile;

            // 플레이어 이동
            transform.position = new Vector3(presentTile.transform.position.x, presentTile.transform.position.y + 0.5f, presentTile.transform.position.z);
        }
    }

	// Use this for initialization
	void Start () {
        presentTile = GameObject.Find("cornerStart");
        transform.position = new Vector3(presentTile.transform.position.x, presentTile.transform.position.y + 0.5f, presentTile.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
