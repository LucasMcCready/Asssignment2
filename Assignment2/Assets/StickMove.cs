using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMove : MonoBehaviour
{
    bool lookR = false;
    float speed = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0);

        /*if (Input.GetKey(KeyCode.Mouse0)) {

            if (lookR == false)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                lookR = true;
            }
            else {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                lookR = false;
            }
        

        }
        */

    }
}
