using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickObjects : MonoBehaviour
{
    [SerializeField]private float kickforce;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigbod = hit.collider.attachedRigidbody;

        if(rigbod != null)
        {
            Vector3 kickdirection = hit.gameObject.transform.position - transform.position;
            kickdirection.y = 0;
            kickdirection.Normalize();

            GetComponent<Rigidbody>().AddForceAtPosition(kickdirection * kickforce, transform.position);
        }
    }
}
