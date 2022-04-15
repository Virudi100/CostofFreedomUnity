using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickControll : MonoBehaviour
{
    public Transform topOfJoystick;

    [SerializeField] private float forwardBackwardTilt = 0;
    [SerializeField] private float sideToSlideTilt = 0;

    // Update is called once per frame
    void Update()
    {
        forwardBackwardTilt = topOfJoystick.rotation.eulerAngles.x;
        if(forwardBackwardTilt < 355 && forwardBackwardTilt > 290)
        {
            forwardBackwardTilt = Mathf.Abs(forwardBackwardTilt - 360);
            Debug.Log("Backward" + forwardBackwardTilt);
            //Move something using forwardBackwardTilt as speed
        }
        else if(forwardBackwardTilt > 5 && forwardBackwardTilt < 74)
        {
            Debug.Log("forward" + forwardBackwardTilt);
            //Move something using forwardBackwardTilt as speed
        }

        sideToSlideTilt = topOfJoystick.rotation.eulerAngles.z;
        if(sideToSlideTilt < 355 && sideToSlideTilt > 290)
        {
            sideToSlideTilt = Mathf.Abs(sideToSlideTilt - 360);
            Debug.Log("Right" + sideToSlideTilt);
            //Turn something using forwardBackwardTilt as speed
        }
        else if (sideToSlideTilt > 5 && sideToSlideTilt < 74)
        {
            Debug.Log("left" + sideToSlideTilt);
            //Turn something using forwardBackwardTilt as speed
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("PlayerHand"))
        {
            transform.LookAt(other.transform.position, transform.up);
        }
    }
}
