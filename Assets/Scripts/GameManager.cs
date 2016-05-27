using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public int Jury;
    public Text textbox;
    public int currentEvidenceCount = 0;
    public int dialougeState;
    public Dictionary<string, List<string>> evidence = new Dictionary<string, List<string>>();
    public bool wallet, shoeprint, receipt, blood, body, particles;
    
	void Start ()
    {
        wallet = true;
        shoeprint = true;
        receipt = true;
        blood = true;
        body = true;
        particles = true;
        dialougeState = 0;
        Jury = 3;
    }
	
	// Update is called once per frame
	void Update () {
        textbox.text = "" + Jury;
	}



}
