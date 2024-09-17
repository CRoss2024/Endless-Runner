using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Create a public reference to the player - we will assign this using the Unity Editor
    public GameObject player;

    void Update()
    {
        // Change our position relative to the player's position
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
}
