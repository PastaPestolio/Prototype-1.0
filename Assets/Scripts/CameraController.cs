using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject Golem;       //Public variable to store a reference to the player game object
    public GameObject Fatman;
    public GameObject Tallguy;
    public grabberscript killscript;

    private Vector3 offset1;
    private Vector3 offset2;
    private Vector3 offset3;  //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset1 = new Vector3(0, 0, -10);
        offset2 = new Vector3(0, 0, -10);
        offset3 = new Vector3(0, 0, -10);
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        if (killscript.character == 0)
        {
            // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
            transform.position = Golem.transform.position + offset1;
        } else if (killscript.character == 1)
        {
            transform.position = Fatman.transform.position + offset2;
        } else if (killscript.character == 2)
        {
            transform.position = Tallguy.transform.position + offset3;
        }
    }
}