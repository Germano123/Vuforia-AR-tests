using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CharacterControllerScript
{
    // reference to the enemy controller
    private EnemyController targetController;

    void Update()
    {
        // check if the image target has been detected
        if (isActive)
        {
            // detect enemies in range
            DetectEnemies();
            // if has a target and the target is active
            if (target != null && targetController.IsActive())
            {
                // go after him
                MoveTo(target.position);
                DealDamage();
            }
            else
            {
                // else go to starting position
                MoveTo(transform.parent.transform.position);
            }
        }
    }

    private void DetectEnemies()
    {
        // collect all the enemies
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(ENEMIES_TAG);
        // auxiliar variable for distance
        float shortestDistance = Mathf.Infinity;
        // auxiliar variable for the nearest enemy
        GameObject nearestEnemy = null;
        // loop through all enemies
        foreach (GameObject enemy in enemies)
        {
            // auxiliar variable to distance between the player and the enemy
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            // check if this enemy is closer than the actual closest enemy
            if (distanceToEnemy < shortestDistance)
            {
                // if so, update shortest distance
                shortestDistance = distanceToEnemy;
                // and the nearest enemy
                nearestEnemy = enemy;
            }
        }

        // check if the nearest enemy is in range
        if (nearestEnemy != null && shortestDistance <= rangeSearch)
        {
            // if so, update the target
            target = nearestEnemy.transform;
            targetController = target.GetComponent<EnemyController>();
        }
    }

    private void MoveTo(Vector3 direction)
    {
        transform.position = Vector3.Lerp(transform.position, direction, speed * Time.deltaTime);
    }

    private void DealDamage()
    {
        // check if the target is int attack range
        if(Vector3.Distance(transform.position, target.position) < rangeAttack)
        {
            // if so, target is in the attack range
            // check the attack speed
            if (true)
            {
                targetController.RecieveDamage(damage);
            }
        }
    }

    // just for tests
    public void OnDrawGizmosSelected()
    {
        // display the search range for enemies
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, rangeSearch);
        // display the attack range for enemies
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangeAttack);

    }
}