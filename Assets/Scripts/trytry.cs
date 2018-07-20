using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trytry : MonoBehaviour {

    private GameObject ball;
    private float ballsize = 1.0f;
    public GameObject target;
    private GameObject lefthand;
    public GameObject Player;
    private bool isWhite; //判断是白法师还是黑法师

	// Use this for initialization
	void Start () {
        if(this.transform.parent.gameObject.name=="Enermy")
        {
            target = GameObject.Find("Player");
            Player = GameObject.Find("Enermy");
        }
        else
        {
            target = GameObject.Find("Enermy");
            //lefthand = GameObject.Find("Controller (left)");
            Player = GameObject.Find("Player");
        }
        isWhite = Player.GetComponent<player_info>().ifisWhite();
        lefthand = this.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.U))
        {
            createBall();
        }
        if(Input.GetKey(KeyCode.U))
        {
            biggerBall();
        }
        if(Input.GetKeyUp(KeyCode.U))
        {
            throwBall();
        }
	}

    public void createBall()
    {
        GameObject container = GameObject.Find("Magic");
        GameObject pfb = Resources.Load("Prefabs/ball") as GameObject;
        GameObject prefabInstance = Instantiate(pfb);
        prefabInstance.transform.parent = container.transform;
        prefabInstance.transform.position = this.transform.position;
        //prefabInstance.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1), ForceMode.Impulse);
        ball = prefabInstance;
        Destroy(ball.GetComponent<Rigidbody>());
        //lefthand.GetComponent<shockhand>().shockDevice();

        //for zq
        //球的本体是ball
        //不同法师用不同特效 你看着办……
        //以及我不太清楚有关Ball的这三块特效是不是可以合并写，如果可以的话你看看怎么处理哈
        if(isWhite)
        {
            //白法师的特效
        }
        else
        {
            //黑法师的特效
        }
    }

    public void biggerBall()
    {
        ballsize += 0.001f;
        if (ballsize >= 2) ballsize = 2.0f;
        ball.transform.localScale = ballsize * new Vector3(0.5f, 0.5f, 0.5f);
        //ball.transform.localScale *= ballsize;
        ball.transform.position = this.transform.position;

        //for zq
        //球的本体是ball
        //不同法师用不同特效 你看着办……
        //以及我不太清楚有关Ball的这三块特效是不是可以合并写，如果可以的话你看看怎么处理哈
        if (isWhite)
        {
            //白法师的特效
        }
        else
        {
            //黑法师的特效
        }
    }

    public void throwBall()
    {
        ball.AddComponent<Rigidbody>();
        ball.GetComponent<Rigidbody>().useGravity = true;
        Vector3 destination = Vector3.Normalize(target.transform.position - transform.position);
        Debug.Log(destination);
        ball.GetComponent<Rigidbody>().AddForce(destination * ballsize * 20, ForceMode.Impulse);
        //lefthand.GetComponent<shockhand>().StopShock();
        ball = null;
        ballsize = 1.0f;

        //for zq
        //球的本体是ball
        //不同法师用不同特效 你看着办……
        //以及我不太清楚有关Ball的这三块特效是不是可以合并写，如果可以的话你看看怎么处理哈
        if (isWhite)
        {
            //白法师的特效
        }
        else
        {
            //黑法师的特效
        }
    }
}
