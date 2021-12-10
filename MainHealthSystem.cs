using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHealthSystem : MonoBehaviour
{
    public int maxHealth;
    public int minHealth;
    public int damageAmount;
    public int playerScore;
    public bool isPlayerCollectGold;
    public GameObject failedPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Die()
    {
        if(minHealth <= 0f)
        {
            Destroy(this); 
        }
    }
}
