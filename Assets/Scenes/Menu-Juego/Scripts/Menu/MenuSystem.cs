using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour
{
    // Cargar la escena del juego
    public void Jugar()
    {
        SceneManager.LoadScene("Tienda"); // nombre exacto de la escena del juego
    }

    // Cargar la escena de ajustes
    public void Ajustes()
    {
        SceneManager.LoadScene("Ajustes"); // nombre exacto de la escena de ajustes
    }

    // Salir del juego
    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();

        // Para que funcione en el editor (solo para pruebas)
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
