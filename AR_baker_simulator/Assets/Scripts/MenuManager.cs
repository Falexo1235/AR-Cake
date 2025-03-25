using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public int Sceneid; // Номер сцены, которую нужно включить

    /// <summary>
    /// Загрузка сцены под нужным номером
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene(Sceneid);
    }
    /// <summary>
    /// Выключение приложения
    /// </summary>
    public void Exit()
    {
        Application.Quit();
    }
}
