using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Character)
    {
        SceneManager.LoadScene(4);
    }
}
