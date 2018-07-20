using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trytry_righthand : MonoBehaviour {

    public GameObject Player;
    public GameObject target;
    private float after_guideopen = 10.0f;
    private bool isWhite; //判断是白法师还是黑法师

    // Use this for initialization
    void Start () {
        Player = transform.parent.gameObject;
        isWhite = Player.GetComponent<player_info>().ifisWhite();
        if(Player.name == "Player")
        {
            target = GameObject.Find("Enermy");
        }
        else
        {
            target = GameObject.Find("Player");
        }
    }
	
	// Update is called once per frame
	void Update () {
        //update guideopen time
        after_guideopen += Time.deltaTime;
        //user press space and it's time to open guidance
        if (Input.GetKeyDown(KeyCode.Space) && after_guideopen>10.0f)
        {
            Debug.Log("开启防御罩");
            OpenGuide();
            after_guideopen = 0.0f;
        }

        //四个招式
        //第一个招式
        if(Input.GetKeyDown(KeyCode.V))
        {
            FirstMoves();
        }

        //第二个招式
        if (Input.GetKeyDown(KeyCode.B))
        {
            SecondMoves();
        }

        //第三个招式
        if (Input.GetKeyDown(KeyCode.N))
        {
            ThirdMoves();
        }

        //第四个招式
        if (Input.GetKeyDown(KeyCode.M))
        {
            FourthMoves();
        }
    }

    //防御罩
    public void OpenGuide()
    {
        //guide shade
        GameObject container = Player;
        GameObject pfb = Resources.Load("Prefabs/guide_shade") as GameObject;
        GameObject prefabInstance = Instantiate(pfb);
        prefabInstance.transform.parent = container.transform;
        prefabInstance.transform.position = Player.transform.position;

        //for zq
        //添加防御罩的特效shader
        //防御罩本体是prefabInstance
        if (isWhite)
        {
            //如果是白法师，用白法师的特效
        }
        else
        {
            //黑法师的特效
        }
    }

    public void FirstMoves()
    {
        //for zq
        //由于还没有想好每个招式对应啥，我现在都先空着，到时候再往里填，当然你要是用了长方体圆柱体什么的麻烦跟我讲一声我就不用想了
        if (isWhite)
        {
            //如果是白法师，用白法师的特效
        }
        else
        {
            //黑法师的特效
        }
    }

    public void SecondMoves()
    {
        //for zq
        //由于还没有想好每个招式对应啥，我现在都先空着，到时候再往里填，当然你要是用了长方体圆柱体什么的麻烦跟我讲一声我就不用想了
        if (isWhite)
        {
            //如果是白法师，用白法师的特效
        }
        else
        {
            //黑法师的特效
        }
    }

    public void ThirdMoves()
    {
        //for zq
        //由于还没有想好每个招式对应啥，我现在都先空着，到时候再往里填，当然你要是用了长方体圆柱体什么的麻烦跟我讲一声我就不用想了
        if (isWhite)
        {
            //如果是白法师，用白法师的特效
        }
        else
        {
            //黑法师的特效
        }
    }

    public void FourthMoves()
    {
        //for zq
        //由于还没有想好每个招式对应啥，我现在都先空着，到时候再往里填，当然你要是用了长方体圆柱体什么的麻烦跟我讲一声我就不用想了
        if (isWhite)
        {
            //如果是白法师，用白法师的特效
        }
        else
        {
            //黑法师的特效
        }
    }
}
