using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClickOld : MonoBehaviour
{
    public GameObject Part; // ����� �����, ������� ����� ��������
    public GameObject Buttons; // ������, ������� ����� �������� ����� ������ �����
    public int PartNumber; // ����� �����, �� ������� ��������
    public PartManager Manager; // ������, ���������� �� ������� ������

    /// <summary>
    /// ��������� ��������� ����� 
    /// ��������� ���� �������� ������ ���������
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
