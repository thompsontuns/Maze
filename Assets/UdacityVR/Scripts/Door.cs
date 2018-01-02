using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    bool locked= true;
    bool opening;
    // Create a boolean value called "opening" that can be checked in Update() 
    public AudioClip Door_locked;
    void Update() {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (opening == true)
        {
            transform.Translate(0f, 8, 0f);
        }
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        // (optionally) Else
        // Play a sound to indicate the door is locked
        if (locked == false)
        {
            opening = true;
        }
        else
        {
            AudioSource ok = GetComponent<AudioSource>();
            ok.clip = Door_locked;
            ok.Play();
        }
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
    }
}
