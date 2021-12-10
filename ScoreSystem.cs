using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public MainHealthSystem mainHealthSystem;
    public const float frameRateCount = 15f;
    public int playerScr;
    public Text playerScoreText;
    public GameObject successPanel;
    

    // Start is called before the first frame update
    IEnumerator  Start()
    {
        while(Application.isPlaying)
        {
            GameSuccess(); 
            yield return new WaitForSeconds(1 / frameRateCount); 
        } 
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("GoldBar"))
        {
            playerScr++;
            Debug.Log("score");
            playerScoreText.text = playerScr.ToString();   
        }
    }

    public void GameSuccess()
    {
        if(playerScr == 7)
        {
            successPanel.SetActive(true);
            Time.timeScale = 0; 
        }
    }

   
}
