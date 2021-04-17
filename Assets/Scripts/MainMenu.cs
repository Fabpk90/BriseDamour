using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject m_Menu;
    public GameObject m_MenuCredit;

    //    public GameObject ;
    //    public GameObject;

    private void Start()
    {
        m_Menu.gameObject.SetActive(true);
        m_MenuCredit.gameObject.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GoToCollection()
    {
        SceneManager.LoadScene("Collection");
    }

    public void GoToCredits()
    {
        m_Menu.gameObject.SetActive(false);
        m_MenuCredit.gameObject.SetActive(true);
    }

    public void QuitCredits()
    {
        m_Menu.gameObject.SetActive(true);
        m_MenuCredit.gameObject.SetActive(false);
    }

    public void Quit()
    {
        //Application.Quit(); //a �viter en cas d'appli web
    }
}
