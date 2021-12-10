using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthSystem : MainHealthSystem 
{
    public float playerHealth;
    


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bomb"))
        {
            playerHealth = damageAmount;
            Destroy(this.gameObject);
            
        }
    }
}
