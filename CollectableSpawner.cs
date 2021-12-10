using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    public GameObject[] goldBar; 

    private void Awake()
    {
        for(int j=1; j<goldBar.Length; j++)
        {
            Vector3 SpawnPosition = new Vector3(Random.Range(-1.5f, 1.22f), 0.048f, Random.Range(-6.3f, -0.82f));
            Instantiate(goldBar[j], SpawnPosition, Quaternion.identity);
        }
         
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
