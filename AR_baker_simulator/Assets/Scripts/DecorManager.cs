using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorManager : MonoBehaviour
{
    public bool isActive = false; // Активна ли декорация
    /// <summary>
    /// Включение и выключение декорации при нажатии на кнопку
    /// </summary>
    public void DecorButton()
    {
        isActive = !isActive;
        gameObject.SetActive(isActive);
    }
}
