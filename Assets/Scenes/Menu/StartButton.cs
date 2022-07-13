using UnityEngine;
using UnityEngine.SceneManagement;

// Класс для начала игры
public class StartButton : MonoBehaviour
{
    // Старт игры 
    public void StartGame()
    {
        SceneManager.LoadScene("Load");
    }
}
