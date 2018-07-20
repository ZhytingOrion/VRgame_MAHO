using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_ball_controll : MonoBehaviour {

    float staytime = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        staytime += Time.deltaTime;
        if (staytime > 5) //五秒内未击中敌人则消失
        {
            Destroy(gameObject); //for zq：消失是不是要有特效你看着办
        }
	}
}
