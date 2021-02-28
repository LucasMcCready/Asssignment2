using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMove : MonoBehaviour
{
    //bool lookR = false;
    public float speed = 0f;
    Vector3 screenPos;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        //Gets the position of the mouse
        Vector3 position = transform.position;
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        screenPos = Camera.main.ScreenToWorldPoint(mousePos);

        //Sets the stickman to move if the mouse is on the screen
        if (screenPos.x > transform.position.x && Mathf.Abs(screenPos.x) < 9.5 && Mathf.Abs(screenPos.y) < 5.5 && transform.position.x > -8.2)
        {

            speed = -5f;


            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0);

            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        else if (Mathf.Abs(screenPos.x) > 9.5 || Mathf.Abs(screenPos.y) > 5.5)
        {
            speed = 0f;
        }

        if (screenPos.x < transform.position.x && Mathf.Abs(screenPos.x) < 9.5 && Mathf.Abs(screenPos.y) < 5.5 && transform.position.x < 8.2)
        {

            speed = 5f;

            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0);

            transform.rotation = Quaternion.Euler(0, 180, 0);

        }
        else if (Mathf.Abs(screenPos.x) > 9.5 || Mathf.Abs(screenPos.y) > 5.5)
        {
            speed = 0f;
        }

        //Tells the animator to start/stop the running animation
        animator.SetFloat("Speed", speed);

    }
}
