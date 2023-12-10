using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    Vector3 move = Vector3.zero;

    public bool LeftMove = false;
    public bool RightMove = false;
    private float Speed = 5;

    private void Awake()
    {
        LeftMove = false;
        RightMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (LeftMove)
        {
            move = new Vector3(-0.1f, 0, 0);
            transform.position += move * Speed * Time.deltaTime;
        }
        if (RightMove)
        {
            move = new Vector3(0.1f, 0, 0);
            transform.position += move * Speed * Time.deltaTime;
        }
    }
}
