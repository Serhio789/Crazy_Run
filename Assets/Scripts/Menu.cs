using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private bool is_menu = true;
    private void Update()
    {
        if (is_menu)
            Time.timeScale = 1f;
        else
            Time.timeScale = 0f;
    }
    public void ChangeMenu()
    {
        is_menu = !is_menu;
    }
}
