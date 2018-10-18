using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        { // check if it's the player, if you want
            Destroy(other.gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
