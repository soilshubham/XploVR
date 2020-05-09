using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public GameObject levelSelection;
    public GameObject mainCanvas;

    private void Start()
    {
        levelSelection.SetActive(false);
        mainCanvas.SetActive(true);
    }
    public void levelCanvas()
    {
        levelSelection.SetActive(true);
        mainCanvas.SetActive(false);
    }

    public void mainMenuCanvas()
    {
        levelSelection.SetActive(false);
        mainCanvas.SetActive(true);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void quit()
    {
        Application.Quit();
    }

    public void levelSelector(string level)
    {
        SceneManager.LoadScene(level);
    }
}
