using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guide_shader_controller : MonoBehaviour {

    private float staytime = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        staytime += Time.deltaTime;
        if(staytime>5.0f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "attack")
        {
            //消失动画，可能需要延长秒数
            Destroy(gameObject);
        }
    }
}
