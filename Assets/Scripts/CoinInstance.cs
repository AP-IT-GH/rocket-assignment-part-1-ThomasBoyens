using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinInstance : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            
            //Update UI
            ScoreManager.instance.AddPoint();
        }
        
    }
    
    
    
}
