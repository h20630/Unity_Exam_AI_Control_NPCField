using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
    [Header("對話")]
    public string Say = "走開啦~";
    public float SaySpeed = 1f;
    [Header("任務")]
    public bool Complete = false;
    public int BateryFinish = 10;
    public int Batery = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
