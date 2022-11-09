using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
   

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

  

    public void TakeDamage (int dmgAmount)
    {
        currentHealth -= dmgAmount;
        Debug.Log("Player Health = " + currentHealth);
        
    }

    public void AddHealth (int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
