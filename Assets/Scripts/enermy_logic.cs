using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermy_logic : MonoBehaviour {

    public GameObject lefthand;
    public GameObject righthand;
    public GameObject target;

	// Use this for initialization
	void Start () {
        lefthand = transform.Find("lefthand").gameObject;
        righthand = transform.Find("righthand").gameObject;
        target = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		//还没写，慢慢来。。。
	}
}
