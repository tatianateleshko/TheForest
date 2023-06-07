using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightC: MonoBehaviour
{
    [SerializeField] GameObject lightGameObject;
    public int enemyCount;
    public void LightControl()
    {
        GameObject lightGameObject = new GameObject("Light");
        Light lightComp = lightGameObject.AddComponent<Light>();
    }
    public void FixedUpdate()
    {
        while (enemyCount > 0)
        {
            transform.localRotation = Quaternion.Euler(187, -366, 0);
        }
    }
}
