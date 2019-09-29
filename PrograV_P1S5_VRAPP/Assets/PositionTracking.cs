using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class PositionTracking : MonoBehaviour
{
    Vector3 oriPos;

    // Start is called before the first frame update
    void Start()
    {
        oriPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Frame.TrakingState == FrameTracking.Tracking)
        {

        } */

        gameObject.transform.position = Frame.Pose.position + oriPos;
        
    }
}
