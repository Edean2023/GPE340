using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : CustomHealth
{
    public int playerHealth;
    GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        healthUI = playerHealth;
        healthBar();

        if (playerHealth <= 0)
        {
            
        }
    }
    private void OnTriggerEnter()
    {
        if (GameObject.FindWithTag("Enemy"))
        {
            playerHealth--;
        }
    }

   
}
