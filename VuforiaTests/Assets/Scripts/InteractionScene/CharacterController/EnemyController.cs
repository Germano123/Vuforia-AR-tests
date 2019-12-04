using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : CharacterControllerScript
{ 
    // check if the enemy has died anytime
    private bool hasDied = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            // check if the enemy is still living haha
            CheckLife();
        }
        if(hasDied)
        {
            // check if this enemy has died anytime
            CheckDeath();
        }
    }

    private void CheckLife()
    {
        // if there's no life anymore
        if (currentHealth <= 0)
        {
            // disable component
            gameObject.SetActive(false);
            // set the target to false
            SetActive(false);
            // set the died checker to true
            hasDied = true;
            Debug.Log("Am I dead? " + hasDied);
        }
    }

    private void CheckDeath()
    {
        Debug.Log("Checking death. Wait for it...");
        if (!isActive && hasDied)
        {
            currentHealth = maxHealth;
            hasDied = false;
            gameObject.SetActive(true);
            SetActive(true);
            Debug.Log("Can I revive? " + !hasDied);
        }
    }

    public override void RecieveDamage(int amount)
    {
        base.RecieveDamage(amount);
        Debug.Log("Recieve " + amount + " of damage...");   
    }
}
