using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    AudioSource laserMew;
    // Start is called before the first frame update
    void Start()
    {
        laserMew = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void playSound()
    {
        laserMew.Play();
    }
}