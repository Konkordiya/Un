using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnTriggerSceneLoader : MonoBehaviour
{
    public string SceneName; 
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") 
        {
            SceneManager.LoadScene(SceneName); 
        }
    }
}
