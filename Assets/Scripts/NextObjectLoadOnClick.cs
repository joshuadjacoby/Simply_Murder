using UnityEngine;
using System.Collections;

public class NextObjectLoadOnClick : MonoBehaviour {
    public GameObject nextGameObject;
    //Use this for initialization
    public GameObject toDestory;
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {        
        Instantiate(nextGameObject, this.gameObject.transform.position, this.gameObject.transform.rotation);
        Destroy(toDestory);

    }
}
