using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGameOverController : MonoBehaviour
{
    public GameObject pauseButton, pauseMenu, panelScore;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // reload
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
