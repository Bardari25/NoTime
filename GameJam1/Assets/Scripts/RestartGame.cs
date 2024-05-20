using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void Restart()
    {
        Time.timeScale = 1; // Zaman �l�e�ini s�f�rla
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Ge�erli sahneyi yeniden y�kle
    }
}
