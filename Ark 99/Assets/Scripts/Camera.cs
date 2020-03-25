using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 cameraPosition = new Vector3(0f + playerPosition.x, 10f + playerPosition.y, -4f + playerPosition.z);
        Quaternion cameraRotation = Quaternion.identity;
        cameraRotation.eulerAngles = new Vector3(67f, 0f, 0f);
        transform.position = cameraPosition;
        transform.rotation = cameraRotation;
    }
}
