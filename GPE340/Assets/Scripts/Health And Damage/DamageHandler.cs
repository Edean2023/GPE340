using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : HealthBar
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
            gameObject.SetActive(false);
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
