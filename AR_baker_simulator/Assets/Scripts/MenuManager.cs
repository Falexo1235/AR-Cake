using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public int Sceneid; // ����� �����, ������� ����� ��������

    /// <summary>
    /// �������� ����� ��� ������ �������
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene(Sceneid);
    }
    /// <summary>
    /// ���������� ����������
    /// </summary>
    public void Exit()
    {
        Application.Quit();
    }
}
