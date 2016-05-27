using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TheEnd : MonoBehaviour
{
    //[HideInInspector]
    private Text textbox;
    private Text NamePlate;
    //private textobject;
    public List<string> dialogueList = new List<string>();
    public List<string> namePlates = new List<string>();
    //public GameObject leftSprite, rightSprite;
    public GameObject Guilty, notGuilty, hung, location;
    private int iterator = 0;

    //Use this for initialization
    private GameManager gameManagerControls;
    public int addToJury;
    // Use this for initialization
    void Start()
    {
        gameManagerControls = GameObject.Find("Main Camera").GetComponent<GameManager>();
        location = GameObject.Find("location");
        textbox = GameObject.Find("Words").GetComponent<Text>();
        textbox.text = dialogueList[iterator];
        NamePlate = GameObject.Find("Character name").GetComponent<Text>();
        NamePlate.text = namePlates[iterator];
    }

    // Update is called once per frame
    void Update()
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
            if (gameManagerControls.Jury < 6 )
            {
                Instantiate(Guilty, location.transform.position, location.transform.rotation);
            }
            else if (gameManagerControls.Jury > 8)
            {
                Instantiate(notGuilty, location.transform.position, location.transform.rotation);
            }
            else
            {
                Instantiate(hung, location.transform.position, location.transform.rotation);
            }


            Destroy(this.gameObject);
        }
        else
        {
            iterator++;
            NextText(dialogueList[iterator], namePlates[iterator]);
        }

    }
}
