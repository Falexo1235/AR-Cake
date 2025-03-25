using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishButton : MonoBehaviour
{
    public GameObject Buttons; //������, ������� ����� ������ ����� �������
    public bool Finished = false; // ���� �� ������ ������ ����������
    /// <summary>
    /// ���������� ���� ������ �������� �������� � ��������� ��������� ���������� �����
    /// </summary>
    public void Finish()
    {
        Finished = true;
        Buttons.SetActive(false);
    }
}
