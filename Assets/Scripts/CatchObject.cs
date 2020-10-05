using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchObject : MonoBehaviour
{
    public GameObject ball;
    public GameObject hand;
    bool catched = false;
    Vector3 ballPosition;

    // Start is called before the first frame update
    void Start()
    {
        ballPosition = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!catched)
            {
                ball.transform.SetParent(hand.transform);
                ball.transform.localPosition = hand.transform.localPosition;
                catched = true;
                ball.GetComponent<Renderer>().material.color = Color.blue;
            } else
            {
                ball.transform.SetParent(null);
                ball.transform.localPosition = ballPosition;
                catched = false;
                ball.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
