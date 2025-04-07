using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f; // Delay before loading the scene
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Invoke("ReloadScene", loadDelay); // Call ReloadScene after 2 seconds
        }
    }

    void ReloadScene() {
            Debug.Log("Player has crossed the finish line!");
            SceneManager.LoadScene(0);

    }
}
