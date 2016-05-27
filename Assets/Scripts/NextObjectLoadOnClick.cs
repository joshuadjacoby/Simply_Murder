using UnityEngine;
using System.Collections;

public class NextObjectLoadOnClick : MonoBehaviour {
    public GameObject nextGameObject, location;
    //Use this for initialization
    public GameObject toDestory;
    void Start () {
        location = GameObject.Find("location");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        Instantiate(nextGameObject, location.transform.position, location.transform.rotation);
        Destroy(toDestory);
    }
}
