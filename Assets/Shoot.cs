using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform shootpoint;
    [SerializeField] float bulletspeed;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject newbullet = Instantiate(bulletPrefab, shootpoint.position, shootpoint.transform.rotation);
            newbullet.GetComponent<Rigidbody>().AddForce(shootpoint.forward * bulletspeed * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
