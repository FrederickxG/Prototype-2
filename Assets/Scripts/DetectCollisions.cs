using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private static int score = 0; // must add static otherwise, it will always stay at 1
    private static int lives = 10;
     private GameManager gameManager;



     void Start()
     {
      gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
     }
    private void OnTriggerEnter(Collider other)
    {

         if (other.CompareTag("Player"))
        {
          gameManager.AddLives(-1);
         Destroy(gameObject);
          }
        else if (other.CompareTag("Animal"))
         {
          gameManager.AddScore(5);
        Destroy(gameObject);
          Destroy(other.gameObject);
       }
}
}
     
 
    

    
