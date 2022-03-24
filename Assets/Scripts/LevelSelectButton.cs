using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LevelSelectButton : MonoBehaviour
{
    public GameObject Menu;
    private MainMenu _mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        _mainMenu = Menu.GetComponent<MainMenu>();
    }

    public void OnClick()
    {
        string levelNumberString = transform.Find("Text").GetComponent<Text>().text;
        if (levelNumberString == "X")
            return;
        int levelNumber;
        Int32.TryParse(levelNumberString, out levelNumber);
        if (levelNumber != 0)
            _mainMenu.SelectLevel(levelNumber);
    }
}
