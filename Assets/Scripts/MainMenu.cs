using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject FirstMenu;
    public GameObject SecondMenu;
    public Button[] LevelButtons;
    private int _currentPage;

    public PlayerState PlrState;

    public void GoToSelectLevel()
    {
        FirstMenu.SetActive(false);
        SecondMenu.SetActive(true);
        _currentPage = 0;
        ChangeLevelNumbers();
    }

    public void BackToMainScreen()
    {
        SecondMenu.SetActive(false);
        FirstMenu.SetActive(true);
    }

    public void NextPage()
    {
        if (_currentPage >= 5)
            return;
        _currentPage++;
        ChangeLevelNumbers();
    }

    public void PreviousPage()
    {
        if (_currentPage <= 0)
            return;
        _currentPage--;
        ChangeLevelNumbers();
    }

    public void SelectLevel(int levelNumber)
    {
        if (levelNumber == 120)
            return;
        //PlrState.level = --levelNumber;
        PlayerPrefs.SetInt("level", --levelNumber);
        SceneManager.LoadScene(1);
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene(1);
    }

    public void NewGame()
    {
        PlayerPrefs.SetInt("level", 0);
        SceneManager.LoadScene(1);
    }

    private void ChangeLevelNumbers()
    {
        for (int i = 1; i <= LevelButtons.Length; i++)
        {
            int levelNumber = i + _currentPage * 20;
            LevelButtons[i-1].transform.Find("Text").GetComponent<Text>().text = $"{levelNumber}";
            //if (levelNumber == 120)
            //    LevelButtons[--i].transform.Find("Text").GetComponent<Text>().text = "X";
        }
    }
}
