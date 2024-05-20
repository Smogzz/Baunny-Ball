using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public GameObject winnerUI;
    public GameObject player;
    public GameObject levelOne;
    public GameObject levelTwo;
    public int currentLevel = 1;
    private void Update()
    {
       if(currentLevel == 2)
       {
            levelOne.SetActive(false);
            levelTwo.SetActive(true);

       }
       
       //is the game over?
        if (gameOver == true)
        {
            GameOver();
        }
    }

    void GameOver() {
        player.GetComponent<Player>().enabled = false;
        Destroy(player.GetComponent<Rigidbody>());
        winnerUI.SetActive(true);
        gameObject.SetActive(false);
    }

}

