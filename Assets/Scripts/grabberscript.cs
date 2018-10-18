using UnityEngine;
using System.Collections;

public class grabberscript : MonoBehaviour
{

    [SerializeField]
    private GameObject GolemSpawn;
    [SerializeField]
    private GameObject GolemBody;
    [SerializeField]
    private GameObject FatmanSpawn;
    [SerializeField]
    private GameObject FatmanBody;
    [SerializeField]
    private GameObject TallguySpawn;
    [SerializeField]
    private GameObject TallguyBody;
    public float character = 0;
    //public CameraController camera1;

    // Use this for initialization
    void Start()
    {
        GolemSpawn.transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        
        // this activates the suicide function
        if (Input.GetKeyDown(KeyCode.K))
        {
            
            suicide();
        }
    }

    
    void suicide()
    {
        
        if (character == 0) {
            GameObject.Instantiate(GolemBody, new Vector3(GolemSpawn.transform.position.x, GolemSpawn.transform.position.y, GolemSpawn.transform.position.z), Quaternion.identity);
            GolemSpawn.transform.position = new Vector3(-35, 2, 0);
            FatmanSpawn.transform.position = new Vector3(0, 0, 0);
            character++;
            
        } else if (character == 1){
            GameObject.Instantiate(FatmanBody, new Vector3(FatmanSpawn.transform.position.x, FatmanSpawn.transform.position.y, FatmanSpawn.transform.position.z), Quaternion.identity);
            FatmanSpawn.transform.position = new Vector3(-35, 2, 0);
            TallguySpawn.transform.position = new Vector3(0, 0, 0);
            character++;
        } else if (character == 2){
            GameObject.Instantiate(TallguyBody, new Vector3(TallguySpawn.transform.position.x, TallguySpawn.transform.position.y, TallguySpawn.transform.position.z), Quaternion.identity);
            TallguySpawn.transform.position = new Vector3(-35, 2, 0);
            GolemSpawn.transform.position = new Vector3(0, 0, 0);
            character = 0;
        }
        //camera1.transform.position = new Vector3(0, 0, 0);
    }
}
