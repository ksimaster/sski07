using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{


    private void Start()
    {
        
    }




    public void Reload()
    {
        SceneManager.LoadScene("Game");
    }

}
