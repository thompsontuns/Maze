using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject KeyPoofPrefab;
    public GameObject Door;
    bool kCollected;

    void Update()
	{
        //Not required, but for fun why not try adding a Key Floating Animation here :)
        
    }

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        Object.Instantiate(KeyPoofPrefab, new Vector3(-24, 3, 25), Quaternion.Euler(-90f,0f,0f));
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        kCollected = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Door.GetComponent<Door>().Unlock();
        Destroy(gameObject);
    }

}
