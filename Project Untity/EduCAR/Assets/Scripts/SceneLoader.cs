using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Slider slider;
    public Text progressText;

    public void CargarEscena(int ID_Escena)
    {
        StartCoroutine(CargarAsincronico(ID_Escena));
    }

    IEnumerator CargarAsincronico (int ID_Escena)
    {
        AsyncOperation operacion = SceneManager.LoadSceneAsync(ID_Escena);
        LoadingScreen.SetActive(true);
        while (!operacion.isDone)
        {
            float progress = Mathf.Clamp01(operacion.progress / .9f);
            slider.value = progress;
            progressText.text = "CARGANDO " + Mathf.Round(progress * 100f) + "%";
            yield return new WaitForSeconds(0.1f);
        }
    }

    public void Cerrar_App()
    {
        Application.Quit();
    }
}
