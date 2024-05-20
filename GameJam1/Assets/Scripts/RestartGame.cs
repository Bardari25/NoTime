using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void Restart()
    {
        Time.timeScale = 1; // Zaman ölçeðini sýfýrla
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Geçerli sahneyi yeniden yükle
    }
}
