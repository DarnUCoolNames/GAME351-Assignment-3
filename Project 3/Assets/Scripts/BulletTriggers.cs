using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTriggers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
/*void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barrel"))
        {
            Vector3 position = other.transform.position;
            Quaternion rotation = other.transform.rotation;

            // Instantiate the replacement prefab at the same position and rotation
            GameObject replacementObject = Instantiate(replacementPrefab, position, rotation);

            Destroy(other.gameObject);
        }*/

    void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Barrel"));
            {
                Destroy(other.gameObject);
            }
        }
    }
