using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonScript : MenuButtonsAbstract
{
    public new void ClickEvent()
    {
        Application.Quit();
    }
}
