using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f; // Delay before loading the scene
    [SerializeField] ParticleSystem finishEffect; // Reference to the particle system prefab
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            finishEffect.Play(); // Play the particle effect
            GetComponent<AudioSource>().Play(); // Play the audio source
            Invoke("ReloadScene", loadDelay); // Call ReloadScene after 2 seconds
        }
    }

    void ReloadScene() {
            Debug.Log("Player has crossed the finish line!");
            SceneManager.LoadScene(0);

    }
}