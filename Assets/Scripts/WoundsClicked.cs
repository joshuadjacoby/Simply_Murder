﻿using UnityEngine;
using System.Collections;

public class WoundsClicked : MonoBehaviour
{
    public GameObject nextGameObject, location;
    //Use this for initialization
    public GameObject toDestory;
    private GameManager gameManagerControls;
    public int addToJury;
    // Use this for initialization
    void Start()
    {
        gameManagerControls = GameObject.Find("Main Camera").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        Instantiate(nextGameObject, location.transform.position, location.transform.rotation);
        gameManagerControls.body = false;
        gameManagerControls.currentEvidenceCount++;
        Destroy(toDestory);
    }
}
