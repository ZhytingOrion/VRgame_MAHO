using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermy_controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "attack_ball")
        {
            //判断位置并扣血

            //for zq
            //这个地方可以加球打在敌人身上的特效，但我不知道是在球的代码上加好还是在敌人身上加好……你看着办

            Destroy(other.gameObject);//如果是球，则去掉这个物体，因为已经打中了
        }
    }
}
