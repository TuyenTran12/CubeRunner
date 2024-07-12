using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject GameOverTitle;
    public GameObject btnGameReplay;
    // Start is called before the first frame update
    void Start()
    {
        GameOverTitle.SetActive(false);
        btnGameReplay.SetActive(false);
    }
    public void showGameOverPanel()
    {
        GameOverTitle.SetActive(true);
        btnGameReplay.SetActive(true);
    }
    public void ReplayGame()
    {
        SceneManager.LoadScene(0);
    }

}
