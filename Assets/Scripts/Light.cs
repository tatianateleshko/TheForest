using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light: MonoBehaviour
{
    [SerializeField] new GameObject gameObject;
    public int enemyCount;

    private void Start()
    {
        
    }
    public void LightControl()
    {
        if(enemyCount > 0)
        {
            _ = GetComponent<Transform>();
        }
    }
}
