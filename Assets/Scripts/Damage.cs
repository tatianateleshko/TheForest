using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] int damage;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        Healthscript healthscript = collision.gameObject.GetComponent<Healthscript>();
        healthscript.TakeDamage(damage);
    }
}
