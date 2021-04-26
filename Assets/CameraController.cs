using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        _offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + _offset;
    }
}
