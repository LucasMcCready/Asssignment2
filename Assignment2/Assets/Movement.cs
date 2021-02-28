﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 screenPos;
    StickMove Target;

    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("STICK").GetComponent<StickMove>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        screenPos = Camera.main.ScreenToWorldPoint(mousePos);

        transform.position = screenPos;

        float AngleRad = Mathf.Atan2(Target.transform.position.y - transform.position.y, Target.transform.position.x - transform.position.x);

        float AngleDeg = (180 / Mathf.PI) * AngleRad;

        this.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);

    }
}
