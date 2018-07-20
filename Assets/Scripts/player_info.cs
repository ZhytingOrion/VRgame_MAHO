using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_info : MonoBehaviour {

    private bool isWhite = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setisWhite(bool choose)
    {
        isWhite = choose;
    }

    public bool ifisWhite()
    {
        return isWhite;
    }
}
