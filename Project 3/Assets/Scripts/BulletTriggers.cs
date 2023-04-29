using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTriggers : MonoBehaviour
{
    public GameObject prefab;
    public ParticleSystem explosion;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barrel"))
        {
            Destroy(other.gameObject);

            ParticleSystem explosionEffect = Instantiate(explosion, other.transform.position, Quaternion.identity);
            explosionEffect.Play();

            GameObject brokenbarrel = Instantiate(prefab);
            brokenbarrel.transform.position = other.gameObject.transform.position;
            brokenbarrel.transform.rotation = other.gameObject.transform.rotation;
        }
    
    //void OnCollisionEnter(Collision other)
    
        if (other.CompareTag("Bandit"))
        {
            Destroy(other.gameObject);
        }
    }
}
