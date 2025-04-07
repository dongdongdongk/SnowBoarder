using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene()
    {
        Debug.Log("Player head crashed!");
        SceneManager.LoadScene(0);

    }
}
