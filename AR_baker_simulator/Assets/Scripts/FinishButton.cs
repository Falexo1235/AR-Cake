using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishButton : MonoBehaviour
{
    public GameObject Buttons; //Кнопки, которые нужно скрыть после нажатия
    public bool Finished = false; // Была ли нажата кнопка завершения
    /// <summary>
    /// Выключение всех кнопок игрового процесса и включение параметра завершения торта
    /// </summary>
    public void Finish()
    {
        Finished = true;
        Buttons.SetActive(false);
    }
}
