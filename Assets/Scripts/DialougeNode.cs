using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DialougeNode : MonoBehaviour {
    //[HideInInspector]
    private Text textbox;
    private Text NamePlate;
    //private textobject;
    public List<string> dialogueList = new List<string>();
    public List<string> namePlates = new List<string>();
    //public GameObject leftSprite, rightSprite;
    public GameObject nextGameObject;
    private int iterator = 0;
    //public GameObject nextNode;

    // Use this for initialization
    void Start ()
    {
        textbox = GameObject.Find("Words").GetComponent<Text>();
        textbox.text = dialogueList[iterator];
        NamePlate = GameObject.Find("Character name").GetComponent<Text>();
        NamePlate.text = namePlates[iterator];
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    void NextText(string text, string name)
    {
        textbox.text = text;
        NamePlate.text = name;
    }
    void OnMouseDown()
    {
        Debug.Log(iterator + "count" + dialogueList.Count);
        
        if ((iterator + 1) == dialogueList.Count)
        {
           // Destroy(leftSprite);
            //Destroy(rightSprite);
            Instantiate(nextGameObject, this.gameObject.transform.position, this.gameObject.transform.rotation);
            Destroy(this.gameObject);
        }
        else
        {
            iterator++;
            NextText(dialogueList[iterator], namePlates[iterator]);
        }
        
    }
}
