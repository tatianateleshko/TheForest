using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] int damage;
    void Start()
    {
        Destroy(gameObject, 3);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Healthscript healthscript = collision.gameObject.GetComponent<Healthscript>();
            healthscript.TakeDamage(damage);
        }
       
    }
}
