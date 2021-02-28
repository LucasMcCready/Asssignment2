using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 screenPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        screenPos = Camera.main.ScreenToWorldPoint(mousePos);

        transform.position = screenPos;
        if (Input.GetKey(KeyCode.Mouse0)) {

            Debug.Log(screenPos);
        
        }

    }
}
