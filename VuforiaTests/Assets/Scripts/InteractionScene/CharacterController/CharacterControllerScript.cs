using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    // variable hard-code control
    protected string ENEMIES_TAG = "Enemy";

    // variable to check if the target is active
    protected bool isActive = false;

    // variable to control health
    [SerializeField] protected int maxHealth = 3;
    [SerializeField] protected int currentHealth = 3;
    [SerializeField] protected int damage = 1;
    // variable to control speed
    [SerializeField] protected float speed = 1f;
    [SerializeField] protected float attackSpeed = 1f;
    // variable to control range search for enemies and range attack
    [SerializeField] protected float rangeSearch = 10f;
    [SerializeField] protected float rangeAttack = 2f;

    // variable to control the target to hit
    protected Transform target = null;

    public void SetActive(bool active)
    {
        isActive = active;
    }

    public bool IsActive()
    {
        return isActive;
    }

    public virtual void RecieveDamage(int amount)
    {
        currentHealth -= amount;
    }
}