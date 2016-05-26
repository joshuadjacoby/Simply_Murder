using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DialougeNode : MonoBehaviour {
    //[HideInInspector]
    public Text textbox;
    //private textobject;
    public List<string> dialogueList = new List<string>();
    //public GameObject leftSprite, rightSprite;
    public GameObject nextGameObject;
    private int iterator = 0;
    //public GameObject nextNode;

    // Use this for initialization
    void Start ()
    {
        textbox = GameObject.Find("Words").GetComponent<Text>();
        textbox.text = dialogueList[iterator];
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    void NextText(string text)
    {
        textbox.text = text;
    }
    void OnMouseDown()
    {
        Debug.Log(iterator + "count" + dialogueList.Count);
        
        if (iterator == dialogueList.Count)
        {
           // Destroy(leftSprite);
            //Destroy(rightSprite);
            Instantiate(nextGameObject, this.gameObject.transform.position, this.gameObject.transform.rotation);
            Destroy(this.gameObject);
        }
        else
        {
            NextText(dialogueList[iterator++]);
            Debug.Log(iterator);
        }
        
    }
}
