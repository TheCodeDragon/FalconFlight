using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour {

    //Dragon Target
    public GameObject Target;

    //Behavioural states:
    /*  WAKE: - Do waking things? futureproofing
     *  HUNT: - fly round the map 
     *  CLIMB: - Avoid hitting buildings, by flying up vertically, till a height ceiling is reached
     *  CHASE: - turn to face the player and charge!
     */
    public enum DragonState
    {
        Wake,
        Hunt,
        Climb,
        Chase
    }
    //Dragon Variables
    public float FL_MoveSpeed;
    public float FL_Turnspeed;
    public float FL_ClimbHeight;
    public float fl_chaseRange;

    //Rigidbody
    private Rigidbody RB;

    public DragonState DS_State;
	// Use this for initialization
	void Start () {
        RB = GetComponent<Rigidbody>();
        DS_State = DragonState.Wake;
	}
	
	// Update is called once per frame
	void Update () {
		if(DS_State == DragonState.Climb)
        {
            Climb();
        }
        else if(DS_State == DragonState.Chase)
        {
            Chase();
        }
        else
        {
            Hunt();
        }

    }
    void Hunt()
    {
        transform.Translate(Vector3.forward * FL_MoveSpeed/4 * Time.deltaTime);
        transform.Rotate(Vector3.up, FL_Turnspeed * Time.deltaTime);
        if(Vector3.Distance(transform.position, Target.transform.position) < fl_chaseRange)
        {
            DS_State = DragonState.Chase;
        }
    }
    void Chase()
    {
        transform.Translate(Vector3.forward * FL_MoveSpeed * Time.deltaTime);
        Vector3 relativePos = Target.transform.position - transform.position;

        // the second argument, upwards, defaults to Vector3.up
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }
    void Climb()
    {
        RB.velocity = Vector3.zero;
        if (transform.position.y < FL_ClimbHeight)
        {
            transform.Translate(Vector3.up * FL_MoveSpeed / 2 * Time.deltaTime);
        }
        else
        {
            DS_State = DragonState.Hunt;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Nofly")
        {
            DS_State = DragonState.Climb;
        }
    }

}
