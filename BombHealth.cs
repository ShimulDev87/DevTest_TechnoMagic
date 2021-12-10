using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombHealth : MainHealthSystem 
{
    public float bombHealth;
    public GameObject bombBlastParticles;
    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            bombHealth = damageAmount;

            StartCoroutine(BombBlaster()); 
        }
    }

    private IEnumerator BombBlaster()
    {
        bombBlastParticles.SetActive(true);
        yield return new WaitForSeconds(0.8f);
        failedPanel.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        Destroy(this.gameObject);
    }

}
