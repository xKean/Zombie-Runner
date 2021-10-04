using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHealth = 3;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        this.currentHealth -= damage;
        if (this.currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

}
