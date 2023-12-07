using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    //variable for the gamr
    public int maxHealth;       //determines max amount of health the player can have
    public int currentHealth;   //tracks current health of the player

    public GameObject hp1;
    public GameObject hp2;


    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 2;                  //set max health to two
        currentHealth = maxHealth;      //set current health to max health
    }

    public void TakeDamage(int amount)
    {
        
            SceneManager.LoadScene("GameOver");         //go to GameOver Scene
        
    }
}