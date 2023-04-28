using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform cameraTransform;
    public float verticalOffset = 10f;  // Set the offset distance

    private void Update()
    {
        // Set the position of the rain system to the position of the camera plus the vertical offset
        transform.position = new Vector3(cameraTransform.position.x, 
                                         cameraTransform.position.y + verticalOffset, 
                                         cameraTransform.position.z);
    }
}
