using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioClip [] Music;
    AudioSource Default;
    AudioSource Shop;

    void Start()
    {
        Default = GetComponent<AudioSource>();
        Default.clip = Music[0];
        Shop = gameObject.AddComponent<AudioSource>();
        Shop.clip = Music[1];
        Default.Play();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Shop")
        {
            Default.Stop();
            Shop.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Shop")
        {
            Shop.Stop();
            Default.Play();
        }
    }
}
