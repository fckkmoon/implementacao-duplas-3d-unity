using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string Menu;
    
    public void ChangeS()
    {
        SceneManager.LoadScene("PrimeiraFase");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
