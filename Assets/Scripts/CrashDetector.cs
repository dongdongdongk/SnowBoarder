using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem crashEffect; // Reference to the particle system prefab
    [SerializeField] AudioClip crashSFX;
    bool hsaCrashed = false; // Flag to check if the player has already crashed
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground") && !hsaCrashed)
        {
            hsaCrashed = true; // Set the flag to true to prevent multiple crashes
            FindObjectOfType<PlayerController>().DisableControls(); // Disable player controls
            GetComponent<AudioSource>().PlayOneShot(crashSFX); // Play the audio source
            crashEffect.Play(); // Play the particle effect
            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene()
    {
        Debug.Log("Player head crashed!");
        SceneManager.LoadScene(0);

    }
}