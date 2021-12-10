using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldBarHealth : MainHealthSystem 
{
    public float goldBarHealth = 5f;
    
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            goldBarHealth = damageAmount;
            Destroy(this.gameObject);
            isPlayerCollectGold = true;
            playerScore++; 
        }
    }

}
