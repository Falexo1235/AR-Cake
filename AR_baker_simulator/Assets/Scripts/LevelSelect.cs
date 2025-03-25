using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    public bool isActive = false; // Активна ли декорация
    public GameObject Buttons1;
    public GameObject Buttons2;
    /// <summary>
    /// Включение и выключение декорации при нажатии на кнопку
    /// </summary>
    public void LevelButton()
    {
        isActive = !isActive;
        Buttons1.SetActive(isActive);
        Buttons2.SetActive(!isActive);
    }
}
