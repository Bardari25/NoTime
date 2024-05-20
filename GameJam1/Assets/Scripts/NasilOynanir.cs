using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayButton : MonoBehaviour
{
    public void ShowHowToPlayScene()
    {
        SceneManager.LoadScene("NasilOynanir"); // "Nasýl Oynanýr" sahnesini aç
    }
}
