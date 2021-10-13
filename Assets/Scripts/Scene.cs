using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void klikPlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void klikExit()
    {
        Application.Quit();
    }
}