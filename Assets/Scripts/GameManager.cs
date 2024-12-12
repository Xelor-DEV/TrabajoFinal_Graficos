using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    // Método para salir del juego
    public void ExitGame()
    {
        Application.Quit();
    }

    // Método para cargar la escena "Gameplay"
    public void LoadGameplayScene()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
