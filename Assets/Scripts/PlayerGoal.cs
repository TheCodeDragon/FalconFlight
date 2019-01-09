using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoal : MonoBehaviour {
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager GM = GameObject.Find("GameManager").GetComponent<GameManager>();
            GM.GameWin();
        }
    }
}
