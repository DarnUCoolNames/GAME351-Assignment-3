using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject prefab;
    public GameObject ShootPoint;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject bullet = Instantiate(prefab);
            bullet.transform.position = this.transform.position;
            bullet.transform.rotation = this.transform.rotation;
        }
    }
}
