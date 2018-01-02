using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject CoinPoofPrefab;

    public void OnCoinClicked() {
       
        // Instantiate the CoinPoof Prefab where this coin is located
        Instantiate(CoinPoofPrefab, transform.position, Quaternion.Euler(-90f,0f,0f));
        // Make sure the poof animates vertically
        CoinPoofPrefab.transform.Rotate(0f,0f,90f);
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
        
    }
    
}
