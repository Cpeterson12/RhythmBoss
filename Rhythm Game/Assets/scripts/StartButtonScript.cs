using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButtonScript : MenuButtonsAbstract
{
    public int StartGameScene;

    public new void ClickEvent()
    {
        SceneManager.LoadScene(StartGameScene);
    }
}
