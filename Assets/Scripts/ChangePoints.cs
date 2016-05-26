using UnityEngine;
using System.Collections;

public class ChangePoints : MonoBehaviour {
    //private GameObject gameManagerObject;
    private GameManager gameManagerControls;
    public int addToJury;
	// Use this for initialization
	void Start () {
        gameManagerControls = GameObject.Find("Main Camera").GetComponent<GameManager>();

        if ((gameManagerControls.Jury + addToJury) > 12)
        {
            gameManagerControls.Jury = 12;
        }
        else if ((gameManagerControls.Jury + addToJury) < 0)
        {
            gameManagerControls.Jury = 12;
        }
        else
        {
            gameManagerControls.Jury += addToJury;
        }


    }
	
	// Update is called once per frame
	void Update () {
	
	}


}
