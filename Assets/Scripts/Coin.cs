using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //Call the game manager, and do the get coin thing
            GameManager GM = GameObject.Find("GameManager").GetComponent<GameManager>();
            GM.CoinGet();
            //cleanup
            Destroy(gameObject);
        }
    }
}
