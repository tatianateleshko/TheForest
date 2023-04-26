using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthscript : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
           Destroy(gameObject);
        }
    }

        
    
}
