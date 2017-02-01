using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {

        offset = transform.position - player.transform.position; // get the offset between the camera and player so we can do third person camera things


	}
	
	// Update is called once per frame
	void Update ()
    {  //dont do camera things here, its not garunteed to be run propperlly, it will do the updating before players can see things
        transform.position = player.transform.position;
	}

    void LateUpdate() //does things after all things in Update are done! good for camera, follow animations, gathering procedural states
    {
        transform.position = player.transform.position + offset;
    }
}
