using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro.EditorUtilities;

public class WriterCheck : MonoBehaviour
{
    public string textAdd;
    public TMP_Text textWrite;
    public TMP_Text textTask;
    public GameObject panelWin;
    public GameObject panelLose;
    private char [] charWrites;
    private char[] charTasks;

    public void AddText()
    {
        if (textWrite.text != textTask.text) 
        {
            textWrite.text += textAdd;
        }
        else
        {
            panelWin.SetActive(true);
        }
        
        TextCheck();
    }

    public void TextCheck()
    {
        
        charWrites = textWrite.text.ToCharArray();
        charTasks = textTask.text.ToCharArray();
        if (charWrites == charTasks) panelWin.SetActive(true);
        if (charWrites.Length > charTasks.Length) panelLose.SetActive(false);
        if (panelWin.activeSelf) panelLose.SetActive(false);
    }
}
