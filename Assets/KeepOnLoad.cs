using UnityEngine;
using System.Collections;

public class KeepOnLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Update is called once per frame
    void Update () {
	
	}
}
