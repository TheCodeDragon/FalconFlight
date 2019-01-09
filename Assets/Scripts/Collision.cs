using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Collision : MonoBehaviour {

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        //Hit player? End the game
        if(collision.gameObject.tag == "Player")
        {
            //Get the game manager
            GameManager GM = GameObject.Find("GameManager").GetComponent<GameManager>();
            //lose the level
            GM.GameLose();
        }
    }
}
