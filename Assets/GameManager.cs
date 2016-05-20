using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public int Jury;
    public Text textbox;
    public string currentEvidence;
    public int dialougeState;
    public Dictionary<string, List<string>> evidence = new Dictionary<string, List<string>>(); 
    
	// Use this for initialization
    //This is gonna be gross
    /// <summary>
    /// MASS DIALOUGE LIST
    /// </summary>
	void Start ()
    {
        dialougeState = 0;
        Jury = 3;

        List<string> dialouge = new List<string>();
        evidence.Add("description", dialouge);

        dialouge = new List<string>();
        evidence.Add("brokenCup", dialouge);

        dialouge = new List<string>();
        evidence.Add("wallet", dialouge);

        dialouge = new List<string>();
        evidence.Add("shoePrint", dialouge);

        dialouge = new List<string>();
        evidence.Add("receipt", dialouge);

        dialouge = new List<string>();
        evidence.Add("footage", dialouge);

        dialouge = new List<string>();
        evidence.Add("bloodSplatter", dialouge);

        dialouge = new List<string>();
        evidence.Add("punctureWound", dialouge);

        dialouge = new List<string>();
        evidence.Add("bruising", dialouge);

        dialouge = new List<string>();
        evidence.Add("wallet", dialouge);

        dialouge = new List<string>();
        evidence.Add("coffeeCup", dialouge);

        dialouge = new List<string>();
        evidence.Add("underNails", dialouge);

        dialouge = new List<string>();
        evidence.Add("stickyNote", dialouge);

        //
        List<string> output = new List<string>();
        evidence.TryGetValue(currentEvidence, out output);
        NextText(output[0]);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void NextText(string text)
    {
        textbox.text = text;
    }

    void OnMouseDown()
    {
        
    }

    void fillEvidence()
    {

    }
}
