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
    
	void Start ()
    {
        dialougeState = 0;
        Jury = 3;
    }
	
	// Update is called once per frame
	void Update () {
	
	}



}
