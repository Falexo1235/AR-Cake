using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorManager : MonoBehaviour
{
    public bool isActive = false; // ������� �� ���������
    /// <summary>
    /// ��������� � ���������� ��������� ��� ������� �� ������
    /// </summary>
    public void DecorButton()
    {
        isActive = !isActive;
        gameObject.SetActive(isActive);
    }
}
