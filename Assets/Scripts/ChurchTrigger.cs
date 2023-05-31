using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChurchTrigger : MonoBehaviour
{
    [SerializeField]
    private int sceneIndex;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneIndex);
        }
        
    }
}
