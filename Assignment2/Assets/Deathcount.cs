﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deathcount : MonoBehaviour
{
    public Text myText;
    int test;
    Kill COUNT;


    // Start is called before the first frame update
    void Start()
    {

        //references the knife
        COUNT = GameObject.FindGameObjectWithTag("WEAPON").GetComponent<Kill>();
        Debug.Log(COUNT.count);

    }

    // Update is called once per frame
    void Update()
    {

        //Sends the text to the screen
       myText.text = "Times Stabbed : " + COUNT.count.ToString();

    }
}
