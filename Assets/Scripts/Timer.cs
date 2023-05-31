using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float time;
    [SerializeField]
    private int sceneIndex;
    void Update()
    {
        time -= Time.deltaTime;

        if(time <= 0)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
