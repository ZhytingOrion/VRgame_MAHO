using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movehead : MonoBehaviour {

    public GameObject Player;
    public GameObject lefthand;
    public GameObject righthand;

	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("press space");
            print("space key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Player.transform.position += Vector3.forward;
            this.transform.position += Vector3.forward;
            Debug.Log("press W");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Player.transform.position -= Vector3.forward;
            this.transform.position -= Vector3.forward;
            Debug.Log("press S");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Player.transform.position -= Vector3.right;
            this.transform.position -= Vector3.right;
            Debug.Log("press A");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Player.transform.position += Vector3.right;
            this.transform.position += Vector3.right;
            Debug.Log("press S");
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.Rotate(0, -10, 0);
            Debug.Log("press J");
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.Rotate(0, 10, 0);
            Debug.Log("press L");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            transform.Rotate(-10, 0, 0);
            Debug.Log("press I");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.Rotate(10, 0, 0);
            Debug.Log("press K");
        }
    }
}
