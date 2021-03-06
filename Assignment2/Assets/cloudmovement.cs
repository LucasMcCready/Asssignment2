﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudmovement : MonoBehaviour
{

    public AnimationCurve curve;
    Vector3 startPos, endPos, mousePos;
    float lerp = 0, duration = 1;

    // Start is called before the first frame update
    void Start()
    {
        //Sets the start position of the cloud
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        //Moves the cloud
        mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        endPos = Camera.main.ScreenToWorldPoint(mousePos);
        lerp += Time.deltaTime / duration;
        transform.position = Vector3.Lerp(startPos, endPos, curve.Evaluate(lerp));
    }
}
