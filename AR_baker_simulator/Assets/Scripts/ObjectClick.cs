using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour
{
    public GameObject Buttons; // ������, ������� ����� �������� ����� ������ �����
    public int MaxNumber;
    public int PartNumber; // ����� �����, �� ������� ��������
    public PartManager Manager; // ������, ���������� �� ������� ������
    public Animator AnimManager;


    /// <summary>
    /// ��������� ��������� ����� 
    /// ��������� ���� �������� ������ ���������
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
