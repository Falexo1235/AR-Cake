using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour
{
    public GameObject Buttons; // Кнопки, которые нужно включить после сборки торта
    public int MaxNumber;
    public int PartNumber; // Номер коржа, на который нажимают
    public PartManager Manager; // Скрипт, отвечающий за порядок коржей
    public Animator AnimManager;


    /// <summary>
    /// Процедура собирания торта 
    /// Последний корж включает кнопки декораций
    /// </summary>
    private void OnMouseDown()
    {
        if (Manager.PartNum == PartNumber && PartNumber == MaxNumber)
        {
            AnimManager.SetInteger("PartNum", MaxNumber);
            Buttons.SetActive(true);
            Manager.PartNum++;
        }        
        else if (Manager.PartNum == PartNumber)
        {
            AnimManager.SetInteger("PartNum", PartNumber);
            Manager.PartNum++;
        }        

    }
}
