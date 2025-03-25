using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeRotation : MonoBehaviour
{
    public FinishButton Fin; // Нажата ли кнопка завершения
 /// <summary>
 /// Вращение торта вокруг своей оси после нажатия на кнопку завершения
 /// </summary>
    private void FixedUpdate()
    {
        if (Fin.Finished == true)
        {
            transform.Rotate(0, 16 * Time.deltaTime, 0);
        }
    }
}
