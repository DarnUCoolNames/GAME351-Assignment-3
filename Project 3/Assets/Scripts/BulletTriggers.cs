using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTriggers : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barrel"))
        {
            Destroy(other.gameObject);
        }
    }
    }
