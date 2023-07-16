using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public string[] tasks = { 
        "доп ",
        "ес ",
        "ски ",
        "би ",
        "ди "
    };

    public int[] difficulty = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
    public int[] different = {0, 1, 2, 3, 4};

    /// <summary>
    /// task - какие слова будут использоваться
    /// difficulty - определяет количество слов в одном задании
    /// different - определяет количество разнообразных слов
    /// 
    /// Слов в задании:
    /// 1 уровень - 1
    /// 2-3 ур. - 2
    /// 4-10 ур. - 3
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
