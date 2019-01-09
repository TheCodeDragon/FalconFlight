using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //the turn speed is what yaw/pitch and roll uses
    public float FL_turnSpeed;
    //move speed, so the player can speed up from 0
    public float FL_moveSpeedMax;
    public float FL_moveSpeedIncrement;
    [SerializeField]
    private float fl_moveSpeedCurrent;
    //start speed, so players don't start going at 0 miles an hour
    public float FL_moveSpeedStart;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        //set up the rigidbody
        rb = GetComponent<Rigidbody>();
        fl_moveSpeedCurrent = FL_moveSpeedStart;
	}
	
	// Update is called once per frame
	void Update () {
        
        Pitch();
        Roll();
        Speed();
	}
    void Pitch()
    {
        transform.Rotate(Vector3.right, Input.GetAxis("Pitch") * FL_turnSpeed);
    }
    void Roll()
    {
        transform.Rotate(Vector3.forward, Input.GetAxis("Roll") * FL_turnSpeed);
    }
    void Speed()
    {
        //Set the forward velocity to the speed
        rb.velocity = transform.forward * fl_moveSpeedCurrent;

        //Capture input to speed up, and set it to either ther next increment up, or to max.
        if (Input.GetButtonDown("SpeedUp"))
        {
            //check you're not already at max
            if (fl_moveSpeedCurrent < FL_moveSpeedMax)
            {
                //check you won't go beyond the max by this increment
                if (fl_moveSpeedCurrent + FL_moveSpeedIncrement < FL_moveSpeedMax)
                {
                    fl_moveSpeedCurrent += FL_moveSpeedIncrement;
                }
                else
                {
                    fl_moveSpeedCurrent = FL_moveSpeedMax;
                }
            }
        }
        //Same as speed up, but the other direction.
        //the increment is basically the lowest the player can go.
        if (Input.GetButtonDown("SpeedDown"))
        {
            if (fl_moveSpeedCurrent > FL_moveSpeedIncrement)
            {
                if (fl_moveSpeedCurrent - FL_moveSpeedIncrement > FL_moveSpeedIncrement)
                {
                    fl_moveSpeedCurrent -= FL_moveSpeedIncrement;
                }
                else
                {
                    fl_moveSpeedCurrent = FL_moveSpeedIncrement;
                }
            }
        }
    }
}
