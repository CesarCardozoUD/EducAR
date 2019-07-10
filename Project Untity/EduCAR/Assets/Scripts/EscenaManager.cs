using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EscenaManager : MonoBehaviour
{
    public void mover_main()
    {
        SceneManager.LoadScene("Main");
    }

    public void salir()
    {
        Application.Quit();
    }
}
