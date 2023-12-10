using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    CamMove camMove;
    public Camera Cam;

    private void Awake()
    {
        camMove = Cam.GetComponent<CamMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LMove()
    {
        camMove.LeftMove = true;
    }

    public void LMoveFalse()
    {
        camMove.LeftMove = false;
    }

    public void RMove()
    {
        camMove.RightMove = true;
    }

    public void RMoveFalse()
    {
        camMove.RightMove = false;
    }
}
