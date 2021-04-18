using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject m_Menu;
    public GameObject m_MenuCollection;
    public GameObject m_MenuCredit;

    private void Start()
    {
        m_Menu.gameObject.SetActive(true);
        m_MenuCredit.gameObject.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("FinalScene");
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

    public void GoToCollection()
    {
        m_Menu.gameObject.SetActive(false);
        m_MenuCredit.gameObject.SetActive(false);
    }

    public void QuitCollection()
    {
        m_Menu.gameObject.SetActive(true);
        m_MenuCredit.gameObject.SetActive(false);
    }
}
