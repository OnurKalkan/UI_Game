using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject mainMenu, inGameMenu;
    public void PlayButton()
    {
        mainMenu.SetActive(false);
        inGameMenu.SetActive(true);
    }

    public void Rex()
    {
        mainMenu.SetActive(true);
        inGameMenu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
