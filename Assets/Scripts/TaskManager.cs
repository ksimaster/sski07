using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public string[] tasks = { 
        "��� ",
        "�� ",
        "��� ",
        "�� ",
        "�� "
    };

    public int[] difficulty = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
    public int[] different = {0, 1, 2, 3, 4};

    /// <summary>
    /// task - ����� ����� ����� ��������������
    /// difficulty - ���������� ���������� ���� � ����� �������
    /// different - ���������� ���������� ������������� ����
    /// 
    /// ���� � �������:
    /// 1 ������� - 1
    /// 2-3 ��. - 2
    /// 4-10 ��. - 3
    /// </summary>

    void Awake()
    {
        if (!PlayerPrefs.HasKey("Level")) PlayerPrefs.SetFloat("Level", 1);

    }

    
    void Update()
    {
        
    }

    public void SetTask()
    {

    }
}
