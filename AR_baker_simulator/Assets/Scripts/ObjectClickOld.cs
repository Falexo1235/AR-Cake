using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClickOld : MonoBehaviour
{
    public GameObject Part; // Часть торта, которую нужно включить
    public GameObject Buttons; // Кнопки, которые нужно включить после сборки торта
    public int PartNumber; // Номер коржа, на который нажимают
    public PartManager Manager; // Скрипт, отвечающий за порядок коржей

    /// <summary>
    /// Процедура собирания торта 
    /// Последний корж включает кнопки декораций
    /// </summary>
    private void OnMouseDown()
    {
        if (Manager.PartNum == PartNumber && PartNumber == 3)
        {
            gameObject.SetActive(false);
            Part.SetActive(true);
            Buttons.SetActive(true);
            Manager.PartNum++;
        }        
        else if (Manager.PartNum == PartNumber)
        {
            gameObject.SetActive(false);
            Part.SetActive(true);
            Manager.PartNum++;
        }
    }
}
