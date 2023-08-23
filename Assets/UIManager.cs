using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject GameoverMenuPanel;

    void Start()
    {
        menuPanel.SetActive(false);
        GameoverMenuPanel.SetActive(false);
    }

    public void ShowMenu()
    {
        menuPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ShowGameoverMenu()
    {
        GameoverMenuPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void SelectTitle()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("TitleScene");
    }

    public void SelectRestart()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

}
