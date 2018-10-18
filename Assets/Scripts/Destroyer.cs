using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    public GameObject DoorTileLos_0;


    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "Key02")
        {
            Destroy(DoorTileLos_0);
        }
        //Check collision name
        Debug.Log("Golem" + col.gameObject.name);
        if (col.gameObject.name == "Key02")
        {
            Destroy(DoorTileLos_0);
            Destroy(col.gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
} 
