using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinmapFollow : MonoBehaviour {
    //the target to follow
    public Transform Target;
	// Update is called once per frame
	void LateUpdate () {

        //Follows a target for minimapping.
        Vector3 newPos = Target.position;
        newPos.y = transform.position.y;
        //updates the position to match the target
        transform.position = newPos;

        //updates to match direction as well
        transform.rotation = Quaternion.Euler(90,Target.eulerAngles.y,0);

	}
}
